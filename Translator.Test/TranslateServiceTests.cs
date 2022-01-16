using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Translator.Test
{
    public class TranslateServiceTests
    {
        [Fact]
        public void GetTranslationMustBeRuturnCorrectValue()
        {
            var translateService = new TranslateService();
            translateService.AddTranslation("orange", "апельсин");

            Assert.Equal("апельсин", translateService.GetTranslation("orange"));
        }
    }
}
