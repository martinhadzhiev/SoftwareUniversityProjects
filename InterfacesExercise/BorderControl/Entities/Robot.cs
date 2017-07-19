public class Robot : ICheckable
{
    private string Model { get; set; }
    public string Id { get; }

    public Robot(string model , string id)
    {
        this.Model = model;
        this.Id = id;
    }
}