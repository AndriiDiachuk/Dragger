using System;
using System.Media;

namespace DesktopUI
{
    public class Sound
    {
        #region Fields

        private SoundPlayer _sndUndo;
        private SoundPlayer _sndMove;
        private SoundPlayer _sndDone;
        #endregion

        #region Constructors

        public Sound()
        {
            _sndUndo = new SoundPlayer(Properties.Resources.DingDong);
            _sndMove = new SoundPlayer(Properties.Resources.TreasurePush);
            _sndDone = new SoundPlayer(Properties.Resources.DullClapping1);
            IsSoundOn = true;
        }

        #endregion

        #region Properties

        public bool IsSoundOn { get; set; }

        #endregion


        #region Methods

        public void PlayUndoSound()
        {
            if (IsSoundOn)
            {
                _sndUndo.Play();
            }
        }

        public void PlayMoveSound()
        {
            if (IsSoundOn)
            {
                _sndMove.Play();
            }
        }

        public void PlayDoneSound()
        {
            if (IsSoundOn)
            {
                _sndDone.Play();
            }
        }

        #endregion
    }
}
