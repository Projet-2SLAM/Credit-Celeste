using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csClient
{

    public class csClient
    {
        private int numeroClient;
        private string cidtClient;
        private string nomClient;
        private string prenomClient;
        private string adresseClient;
        private string codePostalClient;
        private string villeClient;
        private string numTelClient;

        public void Client()
        {
            numeroClient = 0;
            nomClient = "";
            prenomClient = "";
            adresseClient = "";
        }


        public void Client(int numCli)
        {
            numeroClient = numCli;
            nomClient = "";
            prenomClient = "";
            adresseClient = "";
        }


        public void Client(int numCli, string idCli, string nomCli, string prenomCli, string adresseCli)
        {
            numeroClient = numCli;
            cidtClient = idCli;
            nomClient = nomCli;
            prenomClient = prenomCli;
            adresseClient = adresseCli;
        }


        public int getNumeroClient()
        {
            return numeroClient;
        }

        public void setNumeroClient(int numCli)
        {
            numeroClient = numCli;
        }


        public string getNomClient()
        {
            return nomClient;
        }


        public void setNomClient(string nomCli)
        {
            nomClient = nomCli;
        }

        public string getPrenomClient()
        {
            return prenomClient;
        }


        public void setPrenomClient(string prenomCli)
        {
            prenomClient = prenomCli;
        }

        public string getAdresseClient()
        {
            return adresseClient;
        }


        public void setAdresseClient(string adresseCli)
        {
            adresseClient = adresseCli;
        }

        public string getCidtClient()
        {
            return cidtClient;
        }

        public void setCidtClient(string idCli)
        {
            cidtClient = idCli;
        }

        public string getCodePostalClient()
        {
            return codePostalClient;
        }


        public void setCodePostalClient(string codePostalCli)
        {
            codePostalClient = codePostalCli;
        }
        public string getVilleClient()
        {
            return villeClient;
        }


        public void setVilleClient(string villeCli)
        {
            villeClient = villeCli;
        }
        public string getNumTelClient()
        {
            return numTelClient;
        }


        public void setNumTelClient(string numTelCli)
        {
            numTelClient = numTelCli;
        }
    }
}
