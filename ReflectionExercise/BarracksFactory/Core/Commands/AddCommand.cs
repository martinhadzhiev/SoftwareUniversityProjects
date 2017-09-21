namespace BarracksFactory.Core.Commands
{
    using Attributes;
    using Contracts;

    public class AddCommand : IExecutable
    {
        [Inject]
        private string[] data;

        [Inject]
        private readonly IRepository repository;

        [Inject]
        private readonly IUnitFactory unitFactory;

        public AddCommand(string[] data, IRepository repository, IUnitFactory unitFactory)
        {
            this.Data = data;
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public AddCommand()
        {
        }

        private string[] Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public string Execute()
        {
            string unitType = this.Data[1];
            IUnit unitToAdd = this.unitFactory.CreateUnit(unitType);
            this.repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}
