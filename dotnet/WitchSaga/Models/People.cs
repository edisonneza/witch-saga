namespace WitchSaga.Models
{
    public class People
    {
        public Person PersonA { get; set; }
        public Person PersonB { get; set; }

        /// <summary>
        /// Check if the given people object is valid
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            if (!PersonA.IsPersonValid() || !PersonB.IsPersonValid())
                return false;

            return true;
        }
    }

    
}
