respostas = {
    "Questão": [
        "Crie as instâncias de Cachorro e Passaro para que as saídas estejam corretas.",
        "Refatore o código para que seja usada a função NotImplementedError na classe mãe.",
        "Crie a Classe Mãe ItemBiblioteca. Crie a Classe Filha Livro. Implemente um Dicionário para Armazenar as Instâncias de Livro.",
        "Assinale a alternativa correta sobre views no Django.",
        "Corrija o código do views.py com a falha identificada.",
        "Qual das seguintes afirmações sobre o método all() é verdadeira?",
        "Qual das alternativas contém a falha no código do models.py da escola?",
        "Crie o código HTML para o template lista_carros.html.",
        "Crie um template HTML para a view IndexView que liste os produtos disponíveis.",
        "Explique o papel do arquivo models.py na aplicação Django.",
        "Descreva o que acontece quando a view IndexView é acessada e se ela é CBV ou FBV.",
        "Qual a importância de incluir path('', include('ecommerce.urls')) no arquivo urls.py do projeto?",
        "Como a classe Admin em admin.py facilita a administração dos dados da aplicação?",
        "Como você usaria os tags de template do Django para iterar sobre os dados e exibi-los?",
        "Adicione novos modelos à aplicação, como Cliente e Pedido e escreva como ficaria o models.py.",
        "Crie um novo modelo Cliente com os campos nome, email e telefone.",
        "Como ficaria a urls.py do projeto se você criasse um nova app chamada delivery e quisesse redirecionar para o caminho 'seusite.com/delivery'?"
    ],
    "Resposta": [
        # Questão 1
        "cachorro = Cachorro('Totó', 'Vira-lata')\npassaro = Passaro('Piu Piu', 'Canário Belga')",
        # Questão 2
        "class Veiculo:\n    def __init__(self, marca, modelo, ano):\n        self.marca = marca\n        self.modelo = modelo\n        self.ano = ano\n\n    def ligar(self):\n        print(f'{self.marca} {self.modelo} está ligado.')\n\n    def desligar(self):\n        print(f'{self.marca} {self.modelo} está desligado.')\n\n    def mover(self):\n        raise NotImplementedError('Subclasses devem implementar este método.')\n\nclass Carro(Veiculo):\n    def __init__(self, marca, modelo, ano, num_portas):\n...
        # Questão 3
        "class ItemBiblioteca:\n    def __init__(self, id, titulo):\n        self.id = id\n        self.titulo = titulo\n\n    def exibir_informacoes(self):\n        print(f'ID: {self.id}, Título: {self.titulo}')\n\nclass Livro(ItemBiblioteca):\n    def __init__(self, id, titulo, autor, ano_publicacao):\n        super().__init__(id, titulo)\n        self.autor = autor\n        self.ano_publicacao = ano_publicacao\n\n    def exibir_informacoes(self):\n        print(f'ID: {self.id}, Título: {self.titulo}, ...
        # Questão 4
        "As Class-Based Views (CBVs) no Django permitem uma organização mais modular e reutilizável da lógica de visualização.",
        # Questão 5
        "O método post na LivroUpdateView salva as alterações feitas em um livro existente no banco de dados.",
        # Questão 6
        "O método all() retorna True se todos os elementos na lista atenderem à condição especificada.",
        # Questão 7
        "A classe Matricula deve usar ManyToManyField para relacionar Estudante e Curso.",
        # Questão 8
        "<!DOCTYPE html>\n<html lang='pt-br'>\n<head>\n    <meta charset='UTF-8'>\n    <meta name='viewport' content='width=device-width, initial-scale=1.0'>\n    <title>Lista de Carros</title>\n</head>\n<body>\n    <h1>Lista de Carros Disponíveis</h1>\n    <table>\n        <thead>\n            <tr>\n                <th>Marca</th>\n                <th>Modelo</th>\n                <th>Ano</th>\n                <th>Preço</th>\n            </tr>\n        </thead>\n        <tbody>\n            {% for carro i...
        # Questão 9
        "<!DOCTYPE html>\n<html lang='pt-br'>\n<head>\n    <meta charset='UTF-8'>\n    <meta name='viewport' content='width=device-width, initial-scale=1.0'>\n    <title>Produtos Disponíveis</title>\n</head>\n<body>\n    <h1>Lista de Produtos</h1>\n    <table>\n        <thead>\n            <tr>\n                <th>Nome</th>\n                <th>Descrição</th>\n                <th>Preço</th>\n                <th>Estoque</th>\n                <th>Categoria</th>\n            </tr>\n        </thead>\n      ...
        # Questão 10
        "O arquivo models.py define a estrutura do banco de dados da aplicação através de classes. Cada classe representa uma tabela no banco de dados e cada atributo da classe representa uma coluna da tabela.",
        # Questão 11
        "Quando a view IndexView é acessada, ela recupera todos os objetos Produto do banco de dados e renderiza o template 'ecommerce/index.html' passando esses produtos como contexto. Ela é uma Class-Based View (CBV).",
        # Questão 12
        "Incluir path('', include('ecommerce.urls')) no arquivo urls.py do projeto permite que as URLs definidas na aplicação ecommerce sejam acessíveis a partir da raiz do site.",
        # Questão 13
        "A classe Admin em admin.py permite que os modelos sejam gerenciados através da interface administrativa do Django, facilitando a adição, edição e exclusão de registros no banco de dados.",
        # Questão 14
        "Para iterar sobre os dados e exibi-los em um template Django, você pode usar a tag de template {% for %} para iterar sobre uma lista de objetos e exibir seus atributos usando {{ }}.",
        # Questão 15
        "from django.db import models\n\nclass Cliente(models.Model):\n    nome = models.CharField(max_length=100)\n    email = models.EmailField()\n    telefone = models.CharField(max_length=15)\n\n    def __str__(self):\n        return self.nome\n\nclass Pedido(models.Model):\n    cliente = models.ForeignKey(Cliente, on_delete=models.CASCADE)\n    data_pedido = models.DateField()\n    total = models.DecimalField(max_digits=10, decimal_places=2)\n\n    def __str__(self):\n        return f'Pedido {self.i...
        # Questão 16
        "class Cliente(models.Model):\n    nome = models.CharField(max_length=100)\n    email = models.EmailField()\n    telefone = models.CharField(max_length=15)\n\n    def __str__(self):\n        return self.nome",
        # Questão 17
        "from django.urls import path, include\n\nurlpatterns = [\n    path('admin/', admin.site.urls),\n    path('', include('ecommerce.urls')),\n    path('delivery/', include('delivery.urls')),\n]"
    ]
}