namespace BuilderPattern
{
    public class MacBookSeller
    {

        private readonly MacbookProBuilder macbookProBuilder;

        public MacBookSeller() : this(new MacbookPro2018()) { }

        public MacBookSeller(MacbookProBuilder macbookProBuilder)
        {
            this.macbookProBuilder = macbookProBuilder;
        }

        public MacbookPro LowSpecification()
        {
            return macbookProBuilder
                .BuildCPU(new Processor("2.2GHz 6 核心第八代 Intel Core i7 處理器"))
                .BuildMemory(new Memory(16))
                .BuildGraphics(new Graphics("Radeon Pro 555X 配備 4GB GDDR5 記憶體"))
                .BuildStorage(new Storage(256))
                .BuildKeyboard(new Keyboard("中文注音"))
                .Build();
        }

        public MacbookPro HighSpecification()
        {
            return macbookProBuilder
                .BuildCPU(new Processor("2.6GHz 6 核心第八代 Intel Core i7 處理器"))
                .BuildMemory(new Memory(16))
                .BuildGraphics(new Graphics("Radeon Pro 560X 配備 4GB GDDR5 記憶體"))
                .BuildStorage(new Storage(512))
                .BuildKeyboard(new Keyboard("中文注音"))
                .Build();
        }
    }
}
