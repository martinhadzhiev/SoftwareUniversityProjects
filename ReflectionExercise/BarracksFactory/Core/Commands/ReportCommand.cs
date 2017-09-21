namespace BarracksFactory.Core.Commands
{
    using Attributes;
    using Contracts;

    public class ReportCommand : IExecutable
    {
        [Inject]
        private readonly IRepository repository;

        public ReportCommand()
        {
        }

        public ReportCommand(IRepository repository)
        {
            this.repository = repository;
        }

        public string Execute()
        {
            string output = this.repository.Statistics;
            return output;
        }
    }
}
