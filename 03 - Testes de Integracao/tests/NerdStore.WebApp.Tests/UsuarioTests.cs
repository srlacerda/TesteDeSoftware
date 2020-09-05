using NerdStore.WebApp.MVC;
using NerdStore.WebApp.Tests.Config;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace NerdStore.WebApp.Tests
{
    [Collection(nameof(IntegrationWebTestsFixtureCollection))]
    public class UsuarioTests
    {
        private readonly IntegrationTestsFixture<StartupWebTests> _testFixture;

        public UsuarioTests(IntegrationTestsFixture<StartupWebTests> testsFixture)
        {
            _testFixture = testsFixture;
        }
        
        [Fact(DisplayName = "Realizar cadastro com sucesso")]
        [Trait("Categoria","Integração Web Usuário")]
        public async Task Usuario_RealziarCadastro_DeveExecutarComSucesso()
        {
            // Arrange
            var initialResponse = await _testFixture.Client.GetAsync(requestUri: "Identity/Account/Register");
            initialResponse.EnsureSuccessStatusCode();

            var email = "teste2@teste.com";
            var formData = new Dictionary<string, string>
            {
                {"Input.Email", email},
                {"Input.Passord","Teste@123"},
                {"Input.ConfirmPassord","Teste@123"},
            };

            var postRequest = new HttpRequestMessage(HttpMethod.Post, "Identity/Account/Register")
            {
                Content = new FormUrlEncodedContent(formData)
            };

            // Act
            var postResponse = await _testFixture.Client.SendAsync(postRequest);

            // Assert
            var responseString = await postResponse.Content.ReadAsStringAsync();

            postResponse.EnsureSuccessStatusCode();
            Assert.Contains(expectedSubstring: $"Hello {email}", responseString);

        }
    }
}
