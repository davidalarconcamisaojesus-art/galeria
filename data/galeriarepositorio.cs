using galeria.Models;

namespace galeria.data;


public class galeriarepositorio
{
    private static List<Imagem> imagens = new List<Imagem>();

    static galeriarepositorio()
    {
        imagens.Add(new Imagem{ texto= "https://blog.cobasi.com.br/beija-flor/"});
    }
}