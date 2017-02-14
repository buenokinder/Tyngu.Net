# Tyngu.Net


##Api construida para conectar facilmente com Tyngu utilizando .NET

Foi utilizado o Padrão Repository, então quando for acessar o Tyngu, deve-se passar o Modelo de dados que quer acessar e então automaticamente passa a trabalhar com o repositorio.

Isso mantem o principio Open/Close, pois o sistema está fechado para alterações, mas pode ser extendido facilmente adicionando novos modelos de dados.

No momento temos apenas o modelo TynguAccount, que server para trabalhar com sua conta no Tyngu, com ele podemos criar, atualizar e buscar nosso usuário.

###Exemplo de uso 

 ```csharp

;

public TynguExample()
{
 
  //Criacao do servico para acessar tyngu, no caso o servico retorna TynguAccount e recebe UserRequest em suas chamadas, que serão exemplificadas logo abaixo
  private ITynguRepository<TynguAccount, UserRequest> _tynguRepository = new TynguRepository<TynguAccount, UserRequest>(new Uri("http://dev.api.tyngu.com"), "SeuUsuarioTyngu", "Sua Senha Tyngu");
  
  //UserRequest é o modelo de dados utlizado para criação de usuário
  UserRequest _tynguAccount = new UserRequest(){
   email = "teste@teste.com",
   passwd "testepasswd"
   first_name = "Kinder"
   last_name = "Bueno"
   cpf = "99999999999"
  };
  
  //Chamando o servico do Tyngu para criar um usuario
  _tynguRepository.Create(CodigoTynguPesquisas);
  
  //Variavel contendo um código do Tyngu para ser buscado 
  string CodigoTynguPesquisas = "123";
  
  // servico que retorna um Conta Tyngu
  TynguAccount _tynguAccount = _tynguRepository.Get(CodigoTynguPesquisas);
  
}
 ```
