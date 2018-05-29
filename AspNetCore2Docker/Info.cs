namespace AspNetCore2Docker
{
    public class Info
    {
        public Info(string name, string desc)
        {
            this.Name = name;
            this.Desc = desc;
        }
        public string Name { get; set; }
        public string Desc { get; set; }
    }
}
