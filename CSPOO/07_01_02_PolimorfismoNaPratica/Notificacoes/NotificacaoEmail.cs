namespace Notificacoes
{
    public class NotificacaoEmail : Notificacao
    {
        public NotificacaoEmail(string destinatario, string mensagem) : base(destinatario, mensagem)
        {
        }

        public override void Enviar()
        {
            Console.WriteLine($"Enviando email para {Destinatario} com a mensagem '{Mensagem}'.");
        }
    }
}