namespace Notificacoes
{
    public class NotificacaoWhatsApp : Notificacao
    {
        public NotificacaoWhatsApp(string destinatario, string mensagem) : base(destinatario, mensagem)
        {
        }

        public override void Enviar()
        {
            Console.WriteLine($"Enviando whatsapp para {Destinatario} com a mensagem '{Mensagem}'.");
        }
    }
}