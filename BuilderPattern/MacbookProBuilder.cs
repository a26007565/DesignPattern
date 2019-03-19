namespace BuilderPattern
{
    public abstract class MacbookProBuilder
    {
        protected MacbookPro macbookPro;

        protected MacbookProBuilder()
        {
            macbookPro = new MacbookPro();
        }

        public abstract MacbookProBuilder BuildCPU(Processor processor);

        public abstract MacbookProBuilder BuildMemory(Memory size);

        public abstract MacbookProBuilder BuildGraphics(Graphics graphics);

        public abstract MacbookProBuilder BuildStorage(Storage size);

        public abstract MacbookProBuilder BuildKeyboard(Keyboard language);

        public MacbookPro Build()
        {
            return macbookPro;
        }
    }
}
