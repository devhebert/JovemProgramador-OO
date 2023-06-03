namespace AllObjects.Services
{
    public class Casa : Planta
    {
        protected bool pedreiro { get; set; }

        protected bool ajudate { get; set; }
        protected bool areaExterna { get; set; }
        protected bool pintor { get; set; }
        protected bool moveisPlanejados { get; set; }
        protected int quartos { get; set; }
        protected int sala { get; set; }
        protected int cozinha { get; set; }
        protected int banheiro { get; set; }
        
        public Casa(bool engenheiro, bool alvara, bool pedreiro, bool ajudate, bool areaExterna,bool pintor, bool moveisPlanejados, int quartos, int sala, int cozinha, int banheiro) : base(engenheiro, alvara)
        {
            this.pedreiro = pedreiro;
            this.ajudate = ajudate;
            this.areaExterna = areaExterna;
            this.pintor = pintor;
            this.moveisPlanejados = moveisPlanejados;
            this.quartos = quartos;
            this.sala = sala;
            this.cozinha = cozinha;
            this.banheiro = banheiro;
        }

        public override bool construir()
        {
            bool isValid = false;
            if (engenheiro && alvara)
            {
                if (pedreiro && ajudate || pedreiro)
                {
                    Console.WriteLine("Construindo a casa...");
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("A casa não pode ser construida, pois não tem pedreiro.");
                    isValid = false;
                }
            }
            else
            {
                Console.WriteLine("A casa não pode ser construida, pois não alvara e nem engenheiro.");
                isValid = false;
            }
            
            return isValid;
        }

        public bool pintar()
        {
            bool isValid = false;
            if (construir() == true)
            {
                Console.WriteLine("O pintor já iniciou os trabalhos...");
                isValid = true;
            }
            else
            {
                Console.WriteLine("Não é possível pintar a casa antes de construir.");
                isValid = false;
            }

            return isValid;
        }

        public bool colocarMoveisPlanejados()
        {
            bool isValid = false;
            if (construir() == true && pintar() == true)
            {
                Console.WriteLine("Boa, estamos coloando os móveis planejados na casa.");
                isValid = true;
            }
            else
            {
                Console.WriteLine("Não é possível colocar móveis planejados antes de construir e pintar a casa.");
                return false;
            }

            return isValid;
        }
     
        public override string ToString()
        {
            return $"Engenheiro: {engenheiro}, Alvara: {alvara}, Pedreiro: {pedreiro}, Ajudate: {ajudate}, " +
                   $"AreaExterna: {areaExterna}, Pintor: {pintor}, MoveisPlanejados: {moveisPlanejados},  Quartos: {quartos}," +
                   $" Sala: {sala}, Cozinha: {cozinha}, Banheiro: {banheiro}";
        }
    }
}

