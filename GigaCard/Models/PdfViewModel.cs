// Abrir documento
Document pdfDocument = new Document("file.pdf");

// Percorrer as p�ginas
for (int pageCount = 1; pageCount <= pdfDocument.Pages.Count; pageCount++)
{
    // Criar fluxo para cada imagem
    using (FileStream imageStream = new FileStream("Thumbanils_" + pageCount + ".jpg", FileMode.Create))
    {
        // Criar objeto de resolu��o
        Resolution resolution = new Resolution(300);

        // Crie uma inst�ncia do JpegDevice e defina a altura, largura, resolu��o e qualidade da imagem
        JpegDevice jpegDevice = new JpegDevice(45, 59, resolution, 100);

        // Converta uma p�gina espec�fica e salve a imagem para transmitir
        jpegDevice.Process(pdfDocument.Pages[pageCount], imageStream);

        // Fechar fluxo
        imageStream.Close();
    }
}
