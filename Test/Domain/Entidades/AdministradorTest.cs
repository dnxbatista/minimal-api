using minimal_api.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public sealed class AdministradorTest
{
    [TestMethod]
    public void TestarGetSetPropiedades()
    {
        var adm = new Administrador();

        adm.Email = "joao@email.com";
        adm.Senha = "editor";
        adm.Perfil = "Editor";

        Assert.AreEqual(0, adm.Id);
        Assert.AreEqual("joao@email.com", adm.Email);
        Assert.AreEqual("editor", adm.Senha);
        Assert.AreEqual("Editor", adm.Perfil);
    }
}
