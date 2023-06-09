public class Metodos
{
    #region

    //Método de inserção de uma nova pessoa na lista
    public static void InserirPessoaLista(List<Lista> _listAniversario, Lista lista)
    {
        //recuperando lista que foi passada como parametro
        List<Lista> _list = _listAniversario;

        //Adiconando nova pessoa à lista
        _list.Add(lista);

        Metodos.ConsultarLista(_list);

        //Carregando menu principal
        Metodos.CarregarMenuPrincipal();

        //Guarda o valor digitado pelo usuario
        string _menu = Console.ReadLine().ToString();

        //Realiza ação de acorodo com a opção escolhida pelo usuario
        Metodos.MenuOpcoes(_listAniversario, _menu);
    }

    //Visualizar lista
    public static void ConsultarLista(List<Lista> _listAniversario)
    {
        Console.WriteLine();
        Console.WriteLine("Dados das Pessoas:");

        for (int i = 0; i < _listAniversario.Count; i++)
        {

            Console.WriteLine("Nome Completo: {1} {2}\n" +
                "Data de Aniversário: {3} \n" +
                "Faltam {4} dias para esse aniversário \n",
            i,
            _listAniversario[i].Nome,
            _listAniversario[i].Sobrenome,
            _listAniversario[i].DataNascimento,
            _listAniversario[i].Idade);
        }

        //Carregando menu principal
        Metodos.CarregarMenuPrincipal();

        //Recuperando menu digitado pela pessoa
        string _menu = Console.ReadLine().ToString();

        //Carregando menu correspodente
        Metodos.MenuOpcoes(_listAniversario, _menu);
    }

    #endregion

    //Método que monta menu para o usuario
    public static void MenuOpcoes(List<Lista> _listAniversario, string _menu)
    {
        switch (_menu)
        {
            case "1":
                Console.WriteLine("Digite o nome da pessoa.");
                string _nome = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Digite o sobrenome da pessoa.");
                string _sobrenome = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Digite a data de nascimento da pessoa.");
                DateTime _dataNascimento = DateTime.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Pessoa inserida com sucesso");

                Metodos.InserirPessoaLista(_listAniversario, new Lista(_nome, _sobrenome, _dataNascimento));

                break;

            case "2":
                //Visualizando lista

                Metodos.ConsultarLista(_listAniversario);
                (aqui que quero consultar por nome ou metade do nome)
                break;

            case "3":
                Console.WriteLine("Saindo...");
                break;

            default:
                Console.WriteLine("Operação Inválida!");

                break;


        }
    }

    //Carregar MenuPrincipal
    public static void CarregarMenuPrincipal()
    {
        Console.WriteLine("Gerenciamento de Aniversario");
        Console.WriteLine();
        Console.WriteLine("Escolha a operação a ser realizada\n" +
                          "1 - Inserir pessoa \n" +
                          "2 - Consultar lista\n" +
                          "3 - Fechar aplicão");
    }

}
