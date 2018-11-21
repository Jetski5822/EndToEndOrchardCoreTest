using End2EndTestStub.Tests.Context;
using System;
using System.Threading.Tasks;
using Xunit;

namespace End2EndTestStub.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            using (var context = new ConceptContext())
            {
                await context.InitializeAsync();

                var contentItem = await context.CreateContentItem("Blog", (builder) => {
                    builder
                        .DisplayText = "Super Article";
                });

                Assert.NotNull(contentItem);
            }
        }
    }
}
