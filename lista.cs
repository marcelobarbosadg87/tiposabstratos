
	public struct tDados
	{

		public int codigo;

	}

	public struct tLista {

		//Constantes
		public const int NULO = -1;
		public const int MAX = 30;

		//Dados
		public tDados[] vetor;
		public int FIM;

	}

	public void inicializa()
	{
		FIM = NULO;
		vetor = new tDados[MAX];

	}

	public bool vazia()
	{
		return(( FIM == NULO) ? true : false);
	}

	public void inserirDados(tDados	 x, int if)
	{
		int j;

		for(j = FIM + 1; j >= i + 1; j--){
			vetor[j] = vetor[j-1];
		}
		vetor[if] = x;
		FIM = FIM +1;
	}

	public void excluirDados(int if)
	{
		internal j;
		for( j = i; j <= FIM - 1; j++){
			vetor[j] = vetor [j+1];
		}
		FIM = FIM - 1;
	}

	public void qtdLista(){

		return (fim + 1);
	}

	public tDados elemento(int i)
	{
		return(vetor[i]);
	}

