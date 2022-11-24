using CalculoSalario.Classes;
Cadastrar cadastrar = new Cadastrar();
int op = 0;

while (true)
{
    Console.WriteLine("=========Seja bem vindo========\nTecle 1 para cadastrar um novo funcionário\nTecle 2 para consultar colaboradores\nTecle 0 para sair");
    op = Convert.ToInt16(Console.ReadLine());

    switch (op)
    {
        case 1:
            cadastrar.Cadastro();
            break;

        case 2:
            cadastrar.ExibeDados();
            break;
    }

    if(op == 0)
    {
        break;
    }
}
