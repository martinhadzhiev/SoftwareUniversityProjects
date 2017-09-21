namespace BarracksFactory.Core.Commands
{
    using System;
    using Attributes;
    using Contracts;

    public class RetireCommand : IExecutable
    {
        [Inject]
        private string[] data;

        [Inject]
        private readonly IRepository repository;

        public RetireCommand()
        {
        }

        public RetireCommand(string[] data, IRepository repository)
        {
            this.Data = data;
            this.repository = repository;
        }

        private string[] Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public string Execute()
        {
            string unitType = this.Data[1];

            try
            {
                this.repository.RemoveUnit(unitType);
            }
            catch (InvalidOperationException e)
            {
                return e.Message;
            }

            return $"{unitType} retired!";
        }
    }
}
