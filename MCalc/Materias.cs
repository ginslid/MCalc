using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCalc
{
    class NotasProp
    {
        // cria as variáveis de nota 
        public float T1 { get; set; }
        public float T2 { get; set; }
        public float T3 { get; set; }
        public float T4 { get; set; }
        public float T5 { get; set; }
        public float T6 { get; set; }
        public float P1 { get; set; }
        public float P2 { get; set; }
        public float P3 { get; set; }
        public float P4 { get; set; }
        public float MT { get; set; }
        public float MP { get; set; }
        public float MF { get; set; }

        public void notac(int identifier)
        {
            // usa o identificador para definir se a matéria possui 4 ou 6 notas de trabalho e define 0 como nota inicial de trabalhos e provas
            if (identifier == 4)
            {
                T1 = 0.0F;
                T2 = 0.0F;
                T3 = 0.0F;
                T4 = 0.0F;
                P1 = 0.0F;
                P2 = 0.0F;
                P3 = 0.0F;
                P4 = 0.0F;
                MT = 0.0F;
                MP = 0.0F;
                MF = 0.0F;
            }
            else if (identifier == 6)
            {
                T1 = 0.0F;
                T2 = 0.0F;
                T3 = 0.0F;
                T4 = 0.0F;
                T5 = 0.0F;
                T6 = 0.0F;
                P1 = 0.0F;
                P2 = 0.0F;
                P3 = 0.0F;
                P4 = 0.0F;
                MT = 0.0F;
                MP = 0.0F;
                MF = 0.0F;
            }
        }
    }

    // todas as classes de matérias seguem o mesmo modelo e diferenciam-se nos cálculos

    // classe para calcular a nota de Cálculo I
    public class Calculo
    {
        // cria uma nova instância da classe NotasProp
        private NotasProp nota = new NotasProp();
        // atribui o identificador "4" (4 notas de trabalho)
        private int identifier = 4;

        public Calculo()
        {
            // chama o método "notac" para atribuir as notas iniciais de acordo com o identificador 
            nota.notac(identifier);
        }

        public void calculoTotal(float t1, float t2, float t3, float t4, float p1, float p2, float p3, float p4)
        {
            // chama os métodos encapsulados para calcular as médias de trabalho, prova e final passando as notas individuais necessárias
            float mediaT = mediaTrabalho(t1, t2, t3, t4);
            float mediaP = mediaProva(p1, p2, p3, p4);
            float mediaF = mediaTotal(mediaT, mediaP);

            // escreve o resultado dos cálculos formatados para 2 casas decimais e também a mensagem de aprovação ou reprovação
            Console.WriteLine("Sua média de trabalho em Cálculo I: {0:0.00}", mediaT);
            Console.WriteLine("Sua média de prova em Cálculo I: {0:0.00}", mediaP);
            Console.WriteLine("Sua média final em Cálculo I: {0:0.00}", mediaF);

            // chama o método "mensagem" da classe "Info"
            Info.mensagem(mediaF);
        }

        // método para calcular a média de trabalho
        private float mediaTrabalho(float T1, float T2, float T3, float T4)
        {
            float MT = (T1 + T2 + T3 + T4) / 4;
            return MT;
        }

        // método para cálcular a média de prova
        private float mediaProva(float P1, float P2, float P3, float P4)
        {
            float MP = (P1 + P2 + P3 + P4) / 4;
            return MP;
        }

        // método para cálcular a média final
        private float mediaTotal(float MT, float MP)
        {
            float MF = MT * 0.3F + MP * 0.7F;
            return MF;
        }
    }

    // classe para calcular a nota de Física I
    public class fisica
    {
        // cria uma nova instância da classe NotasProp
        private NotasProp nota = new NotasProp();
        // atribui o identificador "6" (6 notas de trabalho)
        private int identifier = 6;

        public fisica()
        {
            // chama o método "notac" para atribuir as notas iniciais de acordo com o identificador
            nota.notac(identifier);
        }

        public void calculoTotal(float t1, float t2, float t3, float t4, float t5, float t6, float p1, float p2, float p3, float p4)
        {
            // chama os métodos encapsulados para calcular as médias de trabalho, prova e final passando as notas individuais necessárias
            float mediaT = mediaTrabalho(t1, t2, t3, t4, t5, t6);
            float mediaP = mediaProva(p1, p2, p3, p4);
            float mediaF = mediaTotal(mediaT, mediaP);

            // escreve o resultado dos cálculos formatados para 2 casas decimais e também a mensagem de aprovação ou reprovação
            Console.WriteLine("Sua média de trabalho em Física I: {0:0.00}", mediaT);
            Console.WriteLine("Sua média de prova em Física I: {0:0.00}", mediaP);
            Console.WriteLine("Sua média final em Física I: {0:0.00}", mediaF);

            // chama o método "mensagem" da classe "Info"
            Info.mensagem(mediaF);
        }

        // método para calcular a média de trabalho
        private float mediaTrabalho(float T1, float T2, float T3, float T4, float T5, float T6)
        {
            float MT = ((T1 * 0.5F) + (T2 * 0.5F) + (T3 * 4) + (T4 * 0.5F) + (T5 * 0.5F) + (T6 * 4)) * 0.1F;
            return MT;
        }

        // método para cálcular a média de prova
        private float mediaProva(float P1, float P2, float P3, float P4)
        {
            float MP = (P1 + P2 + P3 + P4) / 4;
            return MP;
        }

        // método para cálcular a média final
        private float mediaTotal(float MT, float MP)
        {
            float MF = MT * 0.4F + MP * 0.6F;
            return MF;
        }
    }

    // classe para calcular a nota de Geometria Analítica
    public class GeometriaAnalitica
    {
        // cria uma nova instância da classe NotasProp
        private NotasProp nota = new NotasProp();
        // atribui o identificador "4" (4 notas de trabalho)
        private int identifier = 4;

        public GeometriaAnalitica()
        {
            // chama o método "notac" para atribuir as notas iniciais de acordo com o identificador
            nota.notac(identifier);
        }

        public void calculoTotal(float t1, float t2, float t3, float t4, float p1, float p2, float p3, float p4)
        {
            // chama os métodos encapsulados para calcular as médias de trabalho, prova e final passando as notas individuais necessárias
            float mediaT = mediaTrabalho(t1, t2, t3, t4);
            float mediaP = mediaProva(p1, p2, p3, p4);
            float mediaF = mediaTotal(mediaT, mediaP);

            // escreve o resultado dos cálculos formatados para 2 casas decimais e também a mensagem de aprovação ou reprovação
            Console.WriteLine("Sua média de trabalho em Geometria Analítica: {0:0.00}", mediaT);
            Console.WriteLine("Sua média de prova em Geometria Analítica: {0:0.00}", mediaP);
            Console.WriteLine("Sua média final em Geometria Analítica: {0:0.00}", mediaF);

            // chama o método "mensagem" da classe "Info"
            Info.mensagem(mediaF);
        }

        // método para calcular a média de trabalho
        private float mediaTrabalho(float T1, float T2, float T3, float T4)
        {
            float MT = (T1 + T2 + T3 + T4) / 4;
            return MT;
        }

        // método para cálcular a média de prova
        private float mediaProva(float P1, float P2, float P3, float P4)
        {
            float MP = (P1 + P2 + P3 + P4) / 4;
            return MP;
        }

        // método para cálcular a média final
        private float mediaTotal(float MT, float MP)
        {
            float MF = MT * 0.3F + MP * 0.7F;
            return MF;
        }
    }

    // classe para calcular a nota de Química Geral
    public class Quimica
    {
        // cria uma nova instância da classe NotasProp
        private NotasProp nota = new NotasProp();
        // atribui o identificador "4" (4 notas de trabalho)
        private int identifier = 4;

        public Quimica()
        {
            // chama o método "notac" para atribuir as notas iniciais de acordo com o identificador
            nota.notac(identifier);
        }

        public void calculoTotal(float t1, float t2, float t3, float t4, float p1, float p2, float p3, float p4)
        {
            // chama os métodos encapsulados para calcular as médias de trabalho, prova e final passando as notas individuais necessárias
            float mediaT = mediaTrabalho(t1, t2, t3, t4);
            float mediaP = mediaProva(p1, p2, p3, p4);
            float mediaF = mediaTotal(mediaT, mediaP);

            // escreve o resultado dos cálculos formatados para 2 casas decimais e também a mensagem de aprovação ou reprovação
            Console.WriteLine("Sua média de trabalho em Química Geral: {0:0.00}", mediaT);
            Console.WriteLine("Sua média de prova em Química Geral: {0:0.00}", mediaP);
            Console.WriteLine("Sua média final em Química Geral: {0:0.00}", mediaF);

            // chama o método "mensagem" da classe "Info"
            Info.mensagem(mediaF);
        }

        // método para calcular a média de trabalho
        private float mediaTrabalho(float T1, float T2, float T3, float T4)
        {
            float MT = (T1 + T2 + T3 + T4) / 4;
            return MT;
        }

        // método para cálcular a média de prova
        private float mediaProva(float P1, float P2, float P3, float P4)
        {
            float MP = (P1 + P2 + P3 + P4) / 4;
            return MP;
        }

        // método para cálcular a média final
        private float mediaTotal(float MT, float MP)
        {
            float MF = ((MT + MP * 2) / 3) - 0.3F;
            return MF;
        }
    }
}
