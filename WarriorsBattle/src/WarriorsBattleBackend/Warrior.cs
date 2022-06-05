namespace WarriorsBattleBackend
{
    #region Usings
    using System;
    #endregion

    /// <summary>
    /// This class describes a Warrior.
    /// </summary>
    public class Warrior
    {
        #region Attributes
        /// <summary>
        /// The warrior level.
        /// </summary>
        private byte level;

        /// <summary>
        /// The warrior experience.
        /// </summary>
        private ushort experience;

        /// <summary>
        /// The warrior ranks.
        /// </summary>
        private Ranks rank;
        #endregion

        #region Properties
        /// <summary>
        /// The warrior level.
        /// </summary>
        public byte Level
        {
            get 
            {
                return this.level;
            }

            private set
            {
                this.level = value;
            }
        }

        /// <summary>
        /// The warrior experience.
        /// </summary>
        public ushort Experience
        {
            get
            {
                return this.experience;
            }

            private set
            {
                this.experience = value;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Our default constructor.
        /// </summary>
        public Warrior()
        {
            this.level = 1;
            this.experience = 100;
            this.rank = Ranks.Pushover;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="enemy">
        /// 
        /// </param>
        public void Battle(Warrior enemy)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Training(object[] trainigData)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
