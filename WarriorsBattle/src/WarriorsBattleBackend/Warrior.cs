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
                if (value < 100)
                {
                    this.level = value;
                } else 
                {
                    this.level = 100;
                }
                this.rank = (Ranks)((value - 1) / 10);
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
                // se value vale 20000 cosa scrivo negli attributi della classe?

                if (value < 10000){
                    this.level = (byte)(value / 100);
                    this.experience = value;
                } else {
                    this.level = 100;
                    this.experience = 10000;
                }
            }

        }

        public Ranks Rank
        {
            get {
                return this.rank;
            }
            private set {
                this.rank = value;
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
