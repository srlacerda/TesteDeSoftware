﻿using NerdStore.WebApp.MVC;
using NerdStore.WebApp.Tests.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.WebApp.Tests
{
    public class UsuarioTests
    {
        private readonly IntegrationTestsFixture<StartupWebTests> _testFixture;

        public UsuarioTests(IntegrationTestsFixture<StartupWebTests> testsFixture)
        {
            _testFixture = testsFixture;
        }
    }
}
