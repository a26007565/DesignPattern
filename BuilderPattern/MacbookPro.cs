namespace BuilderPattern
{
    public class MacbookPro
    {
        public Processor Processor { get; set; }
        public Memory Memory { get; set; }
        public Storage Storage { get; set; }
        public Graphics Graphics { get; set; }
        public Keyboard Keyboard { get; set; }

        public override string ToString()
        {
            return $@"{{ Macbook:
                        Processor: {Processor.Name}
                        Memory size: {Memory.Size} GB
                        Graphics: {Graphics.Name}
                        Storage size: {Storage.Size} GB
                        Keyboard language: {Keyboard.Language}
                        }}";
        }
    }

    public class Processor
    {
        public string Name { get; set; }

        public Processor(string name)
        {
            Name = name;
        }
    }

    public class Memory
    {
        public int Size { get; set; }

        public Memory(int size)
        {
            Size = size;
        }
    }

    public class Graphics
    {
        public string Name { get; set; }

        public Graphics(string name)
        {
            Name = name;
        }
    }

    public class Storage
    {
        public int Size { get; set; }

        public Storage(int size)
        {
            Size = size;
        }
    }

    public class Keyboard
    {
        public string Language { get; set; }

        public Keyboard(string language)
        {
            Language = language;
        }
    }
}