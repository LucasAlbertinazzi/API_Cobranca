using System.Net.Sockets;
using System.Net;
using System.Collections;
using API_AppCobranca.Controllers;
using API_AppCobranca.Models;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace API_AppCobranca.Suporte
{
    public class ScoreSup
    {
        private Socket Conn;
        private ArrayList resultadoConsulta = new ArrayList();

        private string resultado = string.Empty;
        private string informacao = string.Empty;
        private string negativado = string.Empty;
        private string tipoSituacao = string.Empty;

        public string Monta_String_Envio(InfoScore infoScore)
        {
            if (!String.IsNullOrEmpty(infoScore.cpf))
            {
                if (infoScore.cpf.Length < 14)
                {
                    if (infoScore.nascimento == "")
                    {
                        infoScore.nome = "";
                    }
                    string strConsulta = "CSR10C04";
                    strConsulta += new string(' ', 15);
                    strConsulta += infoScore.codigo.PadLeft(8, '0');
                    strConsulta += infoScore.senha.PadRight(8);
                    strConsulta += infoScore.codconsulta.PadRight(8); //tipo de consulta 391 SPC básico 310 acerta SCORE
                                                                      //CPF
                    if (infoScore.cpf != string.Empty)
                    {
                        strConsulta += "CPF" + infoScore.cpf.PadLeft(11, '0') + new string(' ', 6);
                    }
                    else
                    {
                        strConsulta += new string(' ', 20);
                    }
                    //RG
                    if (infoScore.rg != string.Empty)
                    {
                        strConsulta += "RG" + infoScore.rg.PadLeft(11, '0') + (infoScore.uf != string.Empty ? (infoScore.uf + new string(' ', 5)) : (new string(' ', 7)));
                    }
                    else
                    {
                        strConsulta += new string(' ', 20);
                    }
                    strConsulta += new string(' ', 20);
                    strConsulta += infoScore.nome.PadRight(50);
                    strConsulta += infoScore.nascimento.PadLeft(8, '0');
                    strConsulta += "31122009"; //data do cheque ???
                    strConsulta += "000"; // txtBanco.Text.PadLeft(3, '0');
                    strConsulta += "00000"; // txtAgencia.Text.PadLeft(5, '0');
                    strConsulta += "0000000000000000"; // txtConta.Text.PadLeft(16, '0');
                    strConsulta += "000000000"; // txtCheque.Text.PadLeft(9, '0');
                    strConsulta += "0"; // txtQt.Text.PadLeft(1, '0');
                    strConsulta += "XX"; //XX-nao gravar, CD-Credito Direto, CP-Credito Pessoal, CV - Credito Veiculos, CH - Cheque, OU - Outros,  CC - Cartao Credito
                    strConsulta += "00000000199";
                    strConsulta += new string(' ', 50);
                    strConsulta += new string('0', 4); // ddd
                    strConsulta += new string('0', 9); //telefone
                    strConsulta += new string('0', 8); //cep
                    strConsulta += " "; //origem info cheque - 'C' quando via CMC-7
                    if (infoScore.codconsulta == "391") //SCPC BÁSICO
                    {
                        strConsulta += new string(' ', 8); //reservado
                    }
                    //posicao 293
                    if (infoScore.codconsulta == "310") //ACERTA
                    {
                        strConsulta += "N"; //tipo score 12 meses S ou N
                        strConsulta += "N"; //tipo score cartões S ou N
                        strConsulta += infoScore.uf; //UF protesto
                        strConsulta += " "; //reservado
                        strConsulta += " "; //consultar cheque
                        strConsulta += " "; //limite parcela
                        strConsulta += " "; //sugestão aprova reprova
                    }

                    return strConsulta;
                }

                else //CONSULTA CNPJ
                {
                    //CONSULTA DEFINE CNPJ
                    infoScore.nascimento = "";

                    string strConsulta = "CSR10C04";
                    strConsulta += new string(' ', 15);
                    strConsulta += infoScore.codigo.PadLeft(8, '0');
                    strConsulta += infoScore.senha.PadRight(8);
                    strConsulta += infoScore.codconsulta.PadRight(8); //tipo de consulta
                    if (infoScore.cpf != string.Empty)
                    {
                        strConsulta += "CNPJ" + infoScore.cpf.PadRight(16, ' ');
                    }
                    else
                    {
                        strConsulta += new string(' ', 20);
                    }
                    strConsulta += new string(' ', 40);
                    strConsulta += infoScore.nome.PadRight(50);
                    strConsulta += infoScore.nascimento.PadLeft(8, ' ');
                    strConsulta += "31122009"; //data do cheque ???
                    strConsulta += "000"; // txtBanco.Text.PadLeft(3, '0');
                    strConsulta += "00000"; // txtAgencia.Text.PadLeft(5, '0');
                    strConsulta += "0000000000000000"; // txtConta.Text.PadLeft(16, '0');
                    strConsulta += "000000000"; // txtCheque.Text.PadLeft(9, '0');
                    strConsulta += "0"; // txtQt.Text.PadLeft(1, '0');
                    strConsulta += "XX"; //XX-nao gravar, CD-Credito Direto, CP-Credito Pessoal, CV - Credito Veiculos, CH - Cheque, OU - Outros,  CC - Cartao Credito
                    strConsulta += "00000000199";
                    strConsulta += new string(' ', 50);
                    strConsulta += new string('0', 4); // ddd
                    strConsulta += new string('0', 9); //telefone
                    strConsulta += new string('0', 8); //cep
                    strConsulta += " "; //origem info cheque - 'C' quando via CMC-7

                    strConsulta += new string(' ', 8); //reservado
                    return strConsulta;
                }
            }

            return string.Empty;
        }

        public async Task<string> Consultar(string solicitacao, InfoScore infoScore)
        {
            if(solicitacao != null)
            {
                if (await Conectar("consulta.scpc.inf.br", 9164))
                {
                    try
                    {
                        char[] BufferLerSPC = new char[998];
                        string StrEnvio = solicitacao + '\r';

                        object objData = StrEnvio;
                        byte[] byData = System.Text.Encoding.ASCII.GetBytes(objData.ToString());
                        Conn.Send(byData);

                        bool parar = false;


                        while (parar == false)
                        {
                            byte[] buffer = new byte[1024];
                            int iRx = Conn.Receive(buffer);
                            char[] chars = new char[iRx];

                            System.Text.Decoder d = System.Text.Encoding.ASCII.GetDecoder();
                            int charLen = d.GetChars(buffer, 0, iRx, chars, 0);
                            string szData = new string(chars);

                            resultadoConsulta.Add(szData);

                            if (szData.Substring(39, 1) == "0" || szData.Substring(39, 1) == "9")
                            {
                                parar = true;
                            }
                            else
                            {
                                byData = System.Text.Encoding.ASCII.GetBytes(Convert.ToChar(13).ToString());
                                Conn.Send(byData);
                            }
                        }

                        Conn.Close();

                        string statusConsulta = "";
                        foreach (object xx in resultadoConsulta)
                        {
                            statusConsulta = xx.ToString().Substring(39, 1);
                            break;
                        }

                        if (statusConsulta != "9")
                        {
                            resultado = PreencheLista();

                            await GravaInfoSpc(infoScore);
                            return resultado;

                        }
                        else
                        {
                            resultado = PreencheLista();
                            return resultado;

                        }
                    }
                    catch
                    {
                        return "ERRO";
                    }
                }

                else
                {
                    return "ERRO";
                }
            }

            return string.Empty;
            
        }

        public async Task<bool> Conectar(string ip, int porta)
        {
            // resolve dns.
            IPHostEntry endIp = Dns.GetHostEntry(ip);
            IPAddress[] listaIp = endIp.AddressList;

            // obtem ip do dns
            ip = listaIp[0].ToString();

            try
            {
                //create a new client socket ...
                Conn = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                string szIPSelected = ip;
                string szPort = porta.ToString();
                int alPort = System.Convert.ToInt16(szPort, 10);

                System.Net.IPAddress remoteIPAddress = System.Net.IPAddress.Parse(szIPSelected);
                System.Net.IPEndPoint remoteEndPoint = new System.Net.IPEndPoint(remoteIPAddress, alPort);
                Conn.Connect(remoteEndPoint);
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        private string PreencheLista()
        {

            foreach (object xx in resultadoConsulta)
            {
                resultado += xx.ToString().Substring(48, 79) + "\r\n";
                resultado += xx.ToString().Substring(127, 79) + "\r\n";
                resultado += xx.ToString().Substring(206, 79) + "\r\n";
                resultado += xx.ToString().Substring(285, 79) + "\r\n";
                resultado += xx.ToString().Substring(364, 79) + "\r\n";
                resultado += xx.ToString().Substring(443, 79) + "\r\n";
                resultado += xx.ToString().Substring(522, 79) + "\r\n";
                resultado += xx.ToString().Substring(601, 79) + "\r\n";
                resultado += xx.ToString().Substring(680, 79) + "\r\n";
                resultado += xx.ToString().Substring(759, 79) + "\r\n";
                resultado += xx.ToString().Substring(838, 79) + "\r\n";
                resultado += xx.ToString().Substring(917, 79) + "\r\n";

                informacao += xx.ToString().Substring(48, 79) + "\r\n";
                informacao += xx.ToString().Substring(127, 79) + "\r\n";
                informacao += xx.ToString().Substring(206, 79) + "\r\n";
                informacao += xx.ToString().Substring(285, 79) + "\r\n";
                informacao += xx.ToString().Substring(364, 79) + "\r\n";
                informacao += xx.ToString().Substring(443, 79) + "\r\n";
                informacao += xx.ToString().Substring(522, 79) + "\r\n";
                informacao += xx.ToString().Substring(601, 79) + "\r\n";
                informacao += xx.ToString().Substring(680, 79) + "\r\n";
                informacao += xx.ToString().Substring(759, 79) + "\r\n";
                informacao += xx.ToString().Substring(838, 79) + "\r\n";
                informacao += xx.ToString().Substring(917, 79) + "\r\n";
            }

            return resultado;
        }

        public async Task GravaInfoSpc(InfoScore infoScore)
        {
            foreach (object xx in resultadoConsulta)
            {
                negativado = xx.ToString().Substring(40, 1);
                break;
            }

            if (negativado == "0")
            {
                negativado = "N";
                tipoSituacao = "NADA CONSTA";
            }
            else if (negativado == "1")
            {
                negativado = "N";
                tipoSituacao = "NADA CONSTA COM PASSAGEM";
            }
            else if (negativado == "2")
            {
                negativado = "S";
                tipoSituacao = "CONSTAM INFORMAÇÕES";
            }

            if (infoScore.codconsulta == "391")
            {
                await GravaConsSpcAuto(AbasteceClasse(infoScore, tipoSituacao, negativado, "SCPC", informacao.Trim()));
            }
            if (infoScore.codconsulta == "310")
            {
                await GravaConsSpcAuto(AbasteceClasse(infoScore, tipoSituacao, negativado, "SCPC - ACERTA", informacao.Trim()));
            }
            if (infoScore.codconsulta == "623")
            {
                await GravaConsSpcAuto(AbasteceClasse(infoScore, tipoSituacao, negativado, "SCPC - DEFINE", informacao.Trim()));
            }
        }

        public async Task GravaConsSpcAuto(InfoScore infoGravaSpc)
        {
            DbmarciusbrtsSemanalContext dbContext = new DbmarciusbrtsSemanalContext();
            ScoreBoaVista scoreBoaVista = new ScoreBoaVista(dbContext);

            await scoreBoaVista.Gravar(infoGravaSpc);

            if (infoGravaSpc.tipos == "TITULAR")
            {
                await scoreBoaVista.UpdateTitular(infoGravaSpc);
            }

            if (infoGravaSpc.tipos == "CONJUGE")
            {
                await scoreBoaVista.UpdateConjuge(infoGravaSpc);
            }
        }

        private InfoScore AbasteceClasse(InfoScore infoGravaSpc, string tipoSituacao, string negativado, string informante, string informacao)
        {
            infoGravaSpc.situacao = tipoSituacao;
            infoGravaSpc.informacao = informacao;
            infoGravaSpc.informante = informante;
            infoGravaSpc.negativado = negativado;

            return infoGravaSpc;
        }

        public async Task<byte[]> GerarPdfBytes(string result)
        {
            return await Task.Run(() =>
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    Document doc = new Document();
                    PdfWriter.GetInstance(doc, memoryStream);
                    doc.Open();
                    doc.Add(new Paragraph(result));
                    doc.Close();

                    return memoryStream.ToArray();
                }
            });
        }

        public class ResultadoRequest 
        {
            public string Resultado { get; set; }
        }

        public class InfoScore
        {
            public string? codusuario { get; set; }
            public string? codcliente { get; set; }
            public string? tipos { get; set; }
            public string? codigo { get; set; }
            public string? senha { get; set; }
            public string? codconsulta { get; set; }
            public string? cpf { get; set; }
            public string? rg { get; set; }
            public string? nome { get; set; }
            public string? uf { get; set; }
            public string? nascimento { get; set; }
            public string? situacao { get; set; }
            public string? informacao { get; set; }
            public string? informante { get; set; }
            public string? negativado { get; set; }
        }

    }
}
