namespace Codenation.Challenge
{
    public class State
    {
        

        public State(string name, string acronym)
        {
            Name = name;
            Acronym = acronym;
            
        }

        public State(string name, string acronym, double stateArea) : this(name, acronym)
        {
            Name = name;
            Acronym = acronym;
            StateArea = stateArea;
        }

        public string Name { get; set; }

        public string Acronym { get; set; }

        public double StateArea { get; set; }
    }

}
