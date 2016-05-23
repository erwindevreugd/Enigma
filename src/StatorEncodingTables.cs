namespace Enigma
{
    public class StatorEncodingTableTables
    {
        public static StatorEncodingTable ABC
        {
            get
            {
                StatorEncodingTable table = new StatorEncodingTable();
                table.Add(Key.A, Key.A);
                table.Add(Key.B, Key.B);
                table.Add(Key.C, Key.C);
                table.Add(Key.D, Key.D);
                table.Add(Key.E, Key.E);
                table.Add(Key.F, Key.F);
                table.Add(Key.G, Key.G);
                table.Add(Key.H, Key.H);
                table.Add(Key.I, Key.I);
                table.Add(Key.J, Key.J);
                table.Add(Key.K, Key.K);
                table.Add(Key.L, Key.L);
                table.Add(Key.M, Key.M);
                table.Add(Key.N, Key.N);
                table.Add(Key.O, Key.O);
                table.Add(Key.P, Key.P);
                table.Add(Key.Q, Key.Q);
                table.Add(Key.R, Key.R);
                table.Add(Key.S, Key.S);
                table.Add(Key.T, Key.T);
                table.Add(Key.U, Key.U);
                table.Add(Key.V, Key.V);
                table.Add(Key.W, Key.W);
                table.Add(Key.X, Key.X);
                table.Add(Key.Y, Key.Y);
                table.Add(Key.Z, Key.Z);

                return table;
            }
        }

        public static StatorEncodingTable QWERTZ
        {
            get
            {
                StatorEncodingTable table = new StatorEncodingTable();
                table.Add(Key.A, Key.Q);
                table.Add(Key.B, Key.W);
                table.Add(Key.C, Key.E);
                table.Add(Key.D, Key.R);
                table.Add(Key.E, Key.T);
                table.Add(Key.F, Key.Z);
                table.Add(Key.G, Key.U);
                table.Add(Key.H, Key.I);
                table.Add(Key.I, Key.O);
                table.Add(Key.J, Key.A);
                table.Add(Key.K, Key.S);
                table.Add(Key.L, Key.D);
                table.Add(Key.M, Key.F);
                table.Add(Key.N, Key.G);
                table.Add(Key.O, Key.H);
                table.Add(Key.P, Key.J);
                table.Add(Key.Q, Key.K);
                table.Add(Key.R, Key.P);
                table.Add(Key.S, Key.Y);
                table.Add(Key.T, Key.X);
                table.Add(Key.U, Key.C);
                table.Add(Key.V, Key.V);
                table.Add(Key.W, Key.B);
                table.Add(Key.X, Key.N);
                table.Add(Key.Y, Key.M);
                table.Add(Key.Z, Key.L);

                return table;
            }
        }
    }
}