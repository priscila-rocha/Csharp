namespace mediaAluno
{
    public class Aluno
    {
        public string Nome;
        public double N1, N2, N3;

        public double CaldularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public bool Aprovado()
        {
            if (CaldularNotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante(){
            if (Aprovado())
            {
                return 0.0;
            } else{
                return 60.0 - CaldularNotaFinal();
            }
        }
    }
}