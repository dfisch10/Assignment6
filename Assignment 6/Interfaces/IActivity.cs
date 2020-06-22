namespace Assignment_6.interfaces
{
    public interface IActivity
    {
        /// <summary>
        /// The getter and setter for sequence, which allows us to dictate the sequence order that activities should occur in.
        /// </summary>
        public int sequence { get; set; }

        /// <summary>
        /// Method to "execute" the activity logic.
        /// </summary>
        void Execute()
        {
        }
    }
}