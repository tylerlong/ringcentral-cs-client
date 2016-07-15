namespace RingCentral
{
    public partial class Dictionary : Model
    {
        internal Dictionary(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "dictionary";
            }
        }

        
        public Country Country(string _id = null)
        {
            return new Country(this, _id);
        }
        
        public Language Language(string _id = null)
        {
            return new Language(this, _id);
        }
        
        public Location Location(string _id = null)
        {
            return new Location(this, _id);
        }
        
        public State State(string _id = null)
        {
            return new State(this, _id);
        }
        
        public Timezone Timezone(string _id = null)
        {
            return new Timezone(this, _id);
        }
        
    }
}