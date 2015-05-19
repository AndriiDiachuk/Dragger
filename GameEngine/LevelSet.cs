using System;
using GameEngine.Enums;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Collections.Generic;

namespace GameEngine
{
    public class LevelSet
    {
        #region Private fields
        // Collection of the levels in a XML level set
        private ArrayList _levels = new ArrayList();

        private string _title = string.Empty;
        private string _description = string.Empty;
        private string _filename = string.Empty;

        private int _nrOfLevelsInSet = 0;
        #endregion

        #region Properties

        public string Title
        {
            get { return _title; }
        }

        public string Description
        {
            get { return _description; }
        }

        public string Filename
        {
            get { return _filename; }
        }

        public int NrOfLevelsInSet
        {
            get { return _nrOfLevelsInSet; }
        }

        public int CurrentLevel { get; set; }

        #endregion

        #region Constructors
        public LevelSet(string title, string description, int nrOfLevels, string filename)
        {
            CurrentLevel = 0;
            _title = title;
            _description = description;
            _nrOfLevelsInSet = nrOfLevels;
            _filename = filename;
        }

        public LevelSet()
        {
            CurrentLevel = 0;
        }

        public Level this[int index]
        {
            get { return (Level)_levels[index]; }
        }
        #endregion

        #region Methods
        public void SetLevelSet(string setName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(setName);

            _filename = setName;
            _title = doc.SelectSingleNode("//Title").InnerText;
            _description = doc.SelectSingleNode("//Description").InnerText;

            XmlNodeList levels = doc.SelectNodes("//Level");
            _nrOfLevelsInSet = levels.Count;
        }
        public void SetLevelsInLevelSet(string setName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(setName);

            XmlNodeList levelInfoList = doc.SelectNodes("//Level");

            int levelNr = 1;
            foreach (XmlNode levelInfo in levelInfoList)
            {
                LoadLevel(levelInfo, levelNr);
                levelNr++;
            }
        }
        private void LoadLevel(XmlNode levelInfo, int levelNr)
        {
            // Read the attributes from the level element            
            XmlAttributeCollection xac = levelInfo.Attributes;
            string levelName = xac["Id"].Value;
            int levelWidth = int.Parse(xac["Width"].Value);
            int levelHeight = int.Parse(xac["Height"].Value);
            int nrOfGoals = 0;

            // Read the layout of the level
            XmlNodeList levelLayout = levelInfo.SelectNodes("L");

            // Declare the level map
            ItemType[,] levelMap = new ItemType[levelWidth, levelHeight];

            // Read the level line by line
            for (int i = 0; i < levelHeight; i++)
            {
                string line = levelLayout[i].InnerText;
                bool wallEncountered = false;

                // Read the line character by character
                for (int j = 0; j < levelWidth; j++)
                {
                    // If the end of the line is shorter than the width of the
                    // level, then the rest of the line is filled with spaces.
                    if (j >= line.Length)
                        levelMap[j, i] = ItemType.Space;
                    else
                    {
                        switch (line[j].ToString())
                        {
                            case " ":
                                if (wallEncountered)
                                    levelMap[j, i] = ItemType.Floor;
                                else
                                    levelMap[j, i] = ItemType.Space;
                                break;
                            case "#":
                                levelMap[j, i] = ItemType.Wall;
                                wallEncountered = true;
                                break;
                            case "$":
                                levelMap[j, i] = ItemType.Package;
                                break;
                            case ".":
                                levelMap[j, i] = ItemType.Goal;
                                nrOfGoals++;
                                break;
                            case "@":
                                levelMap[j, i] = ItemType.Dragger;
                                break;
                            case "*":
                                levelMap[j, i] = ItemType.PackageOnGoal;
                                nrOfGoals++;
                                break;
                            case "+":
                                levelMap[j, i] = ItemType.DraggerOnGoal;
                                nrOfGoals++;
                                break;
                            case "=":
                                levelMap[j, i] = ItemType.Space;
                                break;
                        }
                    }
                }
            }
            // Add a new level to the collection of levels in the level set.
            _levels.Add(new Level(levelName, levelMap, levelWidth,
                levelHeight, nrOfGoals, levelNr, _title));
        }
        public static ArrayList GetAllLevelSetInfos()
        {
            ArrayList levelSets = new ArrayList();                                    
            
            File.WriteAllText("map1.xml", Drager.GameEngine.Properties.Resources.boxworld);
            File.WriteAllText("map2.xml", Drager.GameEngine.Properties.Resources.boxworld1);
            File.WriteAllText("DragerLev.dtd", Drager.GameEngine.Properties.Resources.DragerLev);


            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly()
                .GetName().CodeBase).Substring(6);

            string[] fileEntries = Directory.GetFiles(path);

            foreach (string filename in fileEntries)
            {
                FileInfo fileInfo = new FileInfo(filename);

                if (fileInfo.Extension.Equals(".xml"))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(filename);

                    string title = doc.SelectSingleNode("//Title").InnerText;
                    string description =
                        doc.SelectSingleNode("//Description").InnerText;
                    XmlNode levelInfo
                        = doc.SelectSingleNode("//LevelCollection");
                    string author = levelInfo.Attributes[0].Value;
                    XmlNodeList levels = doc.SelectNodes("//Level");

                    levelSets.Add(new LevelSet(title, description, levels.Count, filename));
                }
            }

            return levelSets;
        }
        #endregion      
    }
}
