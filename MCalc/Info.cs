using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCalc
{
    public class Info
    {
        public void menu()
        {
            // exibe o menu principal
            Console.WriteLine("escolha a matéria");
            Console.WriteLine("1) Cálculo I");
            Console.WriteLine("2) Geometria Analítica");
            Console.WriteLine("3) Química Geral");
            Console.WriteLine("4) Física I");
            // string da escolha do usuário
            string C = Console.ReadLine();
            // transforma a string em int
            int J = int.Parse(C);

            // define qual método chamar (getInfo4 ou getInfo6) de acordo com a escolha do usuário
            if (J == 1 || J == 2 || J == 3)
            {
                getInfo4(J);
            }
            else if (J == 4)
            {
                getInfo6();
            }
        }

        // método para adquirir informação sobre as matérias com 4 notas de trabalho
        private void getInfo4(int J)
        {
            // cria 2 arrays para armazenar as notas de trabalho e prova
            float[] notasTrabalho = new float[] { 0, 0, 0, 0 };
            float[] notasProva = new float[] { 0, 0, 0, 0 };
            // cria 2 contadores p e p1
            int p = 0;
            int p1 = 0;

            // loops para receber as notas do usuário e as armazenar nas arrays
            for (int i = 0; i < notasTrabalho.Length; i++)
            {
                Console.WriteLine("Digite a nota do T{0}: ", (i + 1));
                string Tstr = Console.ReadLine();
                notasTrabalho[p] = float.Parse(Tstr);
                p += 1;
            }

            for (int i = 0; i < notasProva.Length; i++)
            {
                Console.WriteLine("Digite a nota da P{0}: ", (i + 1));
                string Pstr = Console.ReadLine();
                notasProva[p1] = float.Parse(Pstr);
                p1 += 1;
            }

            // condicionais para instanciar a matéria escolhida e passar as notas dadas pelo usuário
            if (J == 1)
            {
                Calculo nota = new Calculo();
                nota.calculoTotal(notasTrabalho[0], notasTrabalho[1], notasTrabalho[2], notasTrabalho[3], notasProva[0], notasProva[1], notasProva[2], notasProva[3]);
            }
            else if (J == 2)
            {
                GeometriaAnalitica nota = new GeometriaAnalitica();
                nota.calculoTotal(notasTrabalho[0], notasTrabalho[1], notasTrabalho[2], notasTrabalho[3], notasProva[0], notasProva[1], notasProva[2], notasProva[3]);
            }
            else if (J == 3)
            {
                Quimica nota = new Quimica();
                nota.calculoTotal(notasTrabalho[0], notasTrabalho[1], notasTrabalho[2], notasTrabalho[3], notasProva[0], notasProva[1], notasProva[2], notasProva[3]);
            }
        }

        // método para adquirir informação sobre as matérias com 6 notas de trabalho
        private void getInfo6()
        {
            // cria 2 arrays para armazenar as notas de trabalho e prova
            float[] notasTrabalho = new float[] { 0, 0, 0, 0, 0, 0 };
            float[] notasProva = new float[] { 0, 0, 0, 0 };
            // cria 2 contadores p e p1
            int p = 0;
            int p1 = 0;

            // condicionais para instanciar a matéria escolhida e passar as notas dadas pelo usuário
            for (int i = 0; i < notasTrabalho.Length; i++)
            {
                Console.WriteLine("Digite a nota do T{0}: ", (i + 1));
                string Tstr = Console.ReadLine();
                notasTrabalho[p] = float.Parse(Tstr);
                p += 1;
            }

            for (int i = 0; i < notasProva.Length; i++)
            {
                Console.WriteLine("Digite a nota da P{0}: ", (i + 1));
                string Pstr = Console.ReadLine();
                notasProva[p1] = float.Parse(Pstr);
                p1 += 1;
            }
            // instancia a classe da matéria de física (única com 6 trabalhos para composição de nota)
            fisica nota = new fisica();
            nota.calculoTotal(notasTrabalho[0], notasTrabalho[1], notasTrabalho[2], notasTrabalho[3], notasTrabalho[4], notasTrabalho[5], notasProva[0], notasProva[1], notasProva[2], notasProva[3]);
        }

        public static void mensagem(float media)
        {
            // chama o método encapsulado "mensagemResultado"
            mensagemResultado(media);
        }
        // método encapsulado
        private static void mensagemResultado(float media)
        {
            // condicionais que analisam se o parâmetro "media" é ou não maior que 6 e exibem no console se o usuário foi aprovado ou reprovado
            if (media < 6.0F)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Reprovado");
            }
            else if (media > 6.0F && media < 10.0F)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Aprovado");
            }
            else
            {
                // cria uma nova exceção e escreve a mensagem no console
                Exception e = new InvalidOperationException();
                Console.WriteLine(e.Message);
            }
        }
    }
}