﻿using NUnit.Framework;
using System.Threading.Tasks;

namespace CleanDotnet.Application.IntegrationTests
{
    using static Testing;

    public class TestBase
    {
        [SetUp]
        public async Task TestSetUp()
        {
            await ResetState();
        }
    }
}
