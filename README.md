<h1 align="center">Personal Assist 🤖 </h1>

<div align="center">


| Integrantes      |            Responsabilidades          | Turma      |   RM     |
| --------------   | ------------------------------------- | ---------- | -------- |
| Leonardo Matheus | Documentação do sistema               |  2TDSPN    |  99824   |
| Cauã Couto       | Desenvolvimento do projeto em Java    |  2TDSS     |  97755   |
| Kaique Agostinho | Mapeamento das tabelas e relações     |  2TDSS     |  550815  |
| Thiago Gil       | Documentação do sistema               |  2TDSPV    |  551211  |
</div>

## 📝 Descrição do Projeto 

> O projeto Personal Assist foi criado com a proposta de atender desde empresas até pessoas físicas.

Nosso sistema fornece serviços de recomendação de negócios juntamente com um feedback de acompanhamento. Por exemplo, se temos um cliente que quer investir no ramo da tecnologia, iremos avaliar as melhores atitudes a serem tomadas com base nos seus objetivos e capital.

<h2 name="objetivo">🎯 Objetivos do Projeto</h2>
<li> Prever o comportamento futuro dos clientes com base em dados históricos de interação.  </li>
<li>Sugerir produtos ou serviços relevantes com base nos padrões de comportamento dos clientes. </li>
<li>Analisar sentimentos e feedbacks dos clientes para extrair insights uteis. </li>
<li>Otimizar campanhas de marketing para maximizar o ROI. </li>
<li>• Fornece suporte e assistência personalizada aos clientes por meio de um assistente virtual inteligente.</li>

## ❗❗ Princípios de Clean Code e SOLID ❗❗
<li> Single Responsibility Principle: Cada classe tem uma única responsabilidade.</li>
<li> Dependency Injection: Utilizamos injeção de dependência para promover a testabilidade e reduzir o acoplamento.</li>
<li> Utilize os links de cadastros apresentados na home e use a navbar para acessar a lista de dados de cada classe/li>

<h1> Como Executar </h1>
Clone o repositório. <br>
Restaure os pacotes com dotnet restore. <br>
Execute a aplicação com dotnet run.

public class ClientsControllerTests
{
    [Fact]
    public async Task Register_ShouldReturnOk_WhenClientIsValid()
    {
        // Arrange
        var client = new Client { Name = "Cauã", Sobrenome = "Couto", Email = "couto@gmail.com", Idade = 19};
        var mockService = new Mock<IClientService>();
        mockService.Setup(s => s.RegisterUser(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), iterator.IsAny<int>())
       .Returns(Task.CompletedTask);
        var controller = new ClientsController(mockService.Object);

        // Act
        var result = await controller.Register(client);

        // Assert
        Assert.IsType<OkResult>(result);
    }
}

### 🧑🏻‍💻 Autor 
> Cauã Couto Basques - Turma 2TDSS
