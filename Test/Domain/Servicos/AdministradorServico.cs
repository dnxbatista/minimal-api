using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using minimal_api.Dominio.Entidades;
using minimal_api.Infraestrutura.Db;

namespace Test.Domain.Servicos;

[TestClass]
public sealed class AdministradorServicoTest
{
    private DbContexto CriarContextoDeTeste()
    {
        var options = new DbContextOptionsBuilder<DbContexto>()
        .UseInMemoryDatabase(databaseName: "TestDatabase")
        .Options;

        return new DbContexto(options);
    }

    [TestMethod]
    public void TestandoSalvarAdministrador()
    {
        var adm = new Administrador();
        adm.Email = "joao@email.com";
        adm.Senha = "editor";
        adm.Perfil = "Editor";

        var context = new CriarContextoDeTeste();

        Assert.AreEqual(0, adm.Id);
        Assert.AreEqual("joao@email.com", adm.Email);
        Assert.AreEqual("editor", adm.Senha);
        Assert.AreEqual("Editor", adm.Perfil);
    }
}