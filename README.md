# API_Cobranca

Uma API robusta desenvolvida em .NET 7.0, destinada a facilitar e otimizar os processos de cobrança. Esta API fornece uma série de endpoints para gerenciamento e recuperação de informações relacionadas à cobrança, assim como integrações com outros sistemas e serviços.

## Características Principais:
- **Manipulação de PDFs**: Capacidade de gerar e manipular documentos PDF.
- **Integração com PostgreSQL**: A API utiliza o banco de dados PostgreSQL, aproveitando suas características avançadas como triggers para atualizações automáticas.
- **Manipulação de Imagens**: Funções para processar e manipular imagens conforme necessário.
- **Documentação Swagger**: Utiliza o Swashbuckle para gerar documentação interativa Swagger para a API.
- **Atualizações Automáticas com Triggers**: A API utiliza triggers no PostgreSQL para notificações automáticas de mudanças na tabela `tbl_analise_credito`.

## Tecnologias e Frameworks:
- **Plataforma**: .NET 7.0 (Web).
- **Dependências Principais**:
  - `iTextSharp`: Para operações relacionadas a PDFs.
  - `Microsoft.AspNetCore.OpenApi`: Suporte para OpenAPI.
  - `Microsoft.EntityFrameworkCore.Design`: Design para o Entity Framework Core.
  - `Newtonsoft.Json`: Serialização e desserialização JSON.
  - `Npgsql.EntityFrameworkCore.PostgreSQL`: Integração com PostgreSQL.
  - `SixLabors.ImageSharp`: Manipulação de imagens.
  - `Swashbuckle.AspNetCore`: Geração de documentação Swagger.
  - `System.Drawing.Common`: Operações relacionadas a desenho gráfico.

## Trigger para Atualizações Automáticas:

```sql
CREATE OR REPLACE FUNCTION att_auto_ocorrencia_app_func() RETURNS TRIGGER AS $$
BEGIN
    IF TG_OP = 'UPDATE' THEN
        NOTIFY att_auto_ocorrencia_app_channel, 'Update na tabela tbl_analise_credito';
    ELSIF TG_OP = 'INSERT' THEN
        NOTIFY att_auto_ocorrencia_app_channel, 'Nova linha na tabela tbl_analise_credito';
    END IF;
    
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER att_auto_ocorrencia_app
AFTER INSERT OR UPDATE ON tbl_analise_credito
FOR EACH ROW EXECUTE FUNCTION att_auto_ocorrencia_app_func();
