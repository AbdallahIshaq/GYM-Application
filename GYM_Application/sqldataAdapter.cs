using System.Data;

namespace GYM_Application
{
    internal class sqldataAdapter
    {
        private sqlcommand cmd;

        public sqldataAdapter(sqlcommand cmd)
        {
            this.cmd = cmd;
        }

        internal void Fill(DataSet dS)
        {
            throw new NotImplementedException();
        }
    }
}