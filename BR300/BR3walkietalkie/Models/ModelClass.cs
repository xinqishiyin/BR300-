namespace BR300walkietalkie.Models
{
    public class ModelClass
    {
        string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public decimal MinFrequency
        {
            get
            {
                return minFrequency;
            }

            set
            {
                minFrequency = value;
            }
        }

        public decimal MaxFrequency
        {
            get
            {
                return maxFrequency;
            }

            set
            {
                maxFrequency = value;
            }
        }

        public static ModelClass[] models = { new ModelClass("walkie", 400,480) };
        private ModelClass(string name,int min,int max)
        {
            this.name = name;
            this.minFrequency = min;
            this.maxFrequency = max;
        }
        decimal minFrequency;
        decimal maxFrequency;
        
    }
}
