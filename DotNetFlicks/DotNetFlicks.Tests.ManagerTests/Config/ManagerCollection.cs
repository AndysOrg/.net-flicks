﻿using Xunit;

namespace DotNetFlicks.Tests.ManagerTests.Config
{
    [CollectionDefinition("Managers")]
    public class ManagerCollection : ICollectionFixture<ManagerFixture>
    {
        // This class has no code, and is never created. Its purpose is simply to be the
        //place to apply [CollectionDefinition] and all the ICollectionFixture<> interfaces.
        //https://xunit.github.io/docs/shared-context.html#collection-fixture
    }
}