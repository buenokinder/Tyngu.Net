# Tyngu.Net
Tyngu.Net 


Api construida para conectar facilmente com Tyngu utilizando .NET

Foi utilizado o Padrão Repository, então quando for acessar o Tyngu, deve-se passar o Modelo de dados que quer acessar e então automaticamente passa a trabalhar com o repositorio.
Isso mantem o principio Open/Close, pois o sistema está fechado para alterações, mas pode ser extendido facilmente adicionando novos modelos de dados.
No momento temos apenas o modelo TynguAccount, que server para trabalhar com sua conta no Tyngu, com ele podemos criar, atualizar e buscar nosso usuário.

 ```csharp

private ITynguRepository<T, U> _tynguRepository;

public TynguServices()
{

  this._tynguRepository = new TynguRepository<T, U>(new Uri(TynguProvider.Url), TynguProvider.User, TynguProvider.Password);
}

