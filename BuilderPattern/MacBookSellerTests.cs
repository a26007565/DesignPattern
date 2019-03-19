using System;
using Xunit;

namespace BuilderPattern
{
    public class MacBookSellerTests
    {
        private readonly MacBookSeller _macBookSeller;

        public MacBookSellerTests()
        {
            _macBookSeller = new MacBookSeller();
        }

        [Fact]
        public void LowSpec_StateUnderTest_ExpectedBehavior()
        {
            // Act
            var macbook = _macBookSeller.LowSpecification();
            Console.WriteLine(macbook);

            // Assert
            Assert.Equal("2.2GHz 6 �֤߲ĤK�N Intel Core i7 �B�z��", macbook.Processor.Name);
            Assert.Equal(16, macbook.Memory.Size);
            Assert.Equal("Radeon Pro 555X �t�� 4GB GDDR5 �O����", macbook.Graphics.Name);
            Assert.Equal(256, macbook.Storage.Size);
            Assert.Equal("����`��", macbook.Keyboard.Language);
        }

        [Fact]
        public void HighSpec_StateUnderTest_ExpectedBehavior()
        {
            // Act
            var macbook = _macBookSeller.HighSpecification();

            // Assert
            Assert.Equal("2.6GHz 6 �֤߲ĤK�N Intel Core i7 �B�z��", macbook.Processor.Name);
            Assert.Equal(16, macbook.Memory.Size);
            Assert.Equal("Radeon Pro 560X �t�� 4GB GDDR5 �O����", macbook.Graphics.Name);
            Assert.Equal(512, macbook.Storage.Size);
            Assert.Equal("����`��", macbook.Keyboard.Language);
        }
    }
}
