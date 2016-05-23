namespace Enigma
{
    public class RotorEncodingTableTables
    {
        public static RotorEncodingTable IC
        {
            get
            {
                RotorEncodingTable table = new RotorEncodingTable();
                table.Add(Key.A, Key.D);
                table.Add(Key.B, Key.M);
                table.Add(Key.C, Key.T);
                table.Add(Key.D, Key.W);
                table.Add(Key.E, Key.S);
                table.Add(Key.F, Key.I);
                table.Add(Key.G, Key.L);
                table.Add(Key.H, Key.R);
                table.Add(Key.I, Key.U);
                table.Add(Key.J, Key.Y);
                table.Add(Key.K, Key.Q);
                table.Add(Key.L, Key.N);
                table.Add(Key.M, Key.K);
                table.Add(Key.N, Key.F);
                table.Add(Key.O, Key.E);
                table.Add(Key.P, Key.J);
                table.Add(Key.Q, Key.C);
                table.Add(Key.R, Key.A);
                table.Add(Key.S, Key.Z);
                table.Add(Key.T, Key.B);
                table.Add(Key.U, Key.P);
                table.Add(Key.V, Key.G);
                table.Add(Key.W, Key.X);
                table.Add(Key.X, Key.O);
                table.Add(Key.Y, Key.H);
                table.Add(Key.Z, Key.V);

                return table;
            }
        }

        public static RotorEncodingTable IIC
        {
            get
            {
                RotorEncodingTable table = new RotorEncodingTable();
                table.Add(Key.A, Key.H);
                table.Add(Key.B, Key.Q);
                table.Add(Key.C, Key.Z);
                table.Add(Key.D, Key.G);
                table.Add(Key.E, Key.P);
                table.Add(Key.F, Key.J);
                table.Add(Key.G, Key.T);
                table.Add(Key.H, Key.M);
                table.Add(Key.I, Key.O);
                table.Add(Key.J, Key.B);
                table.Add(Key.K, Key.L);
                table.Add(Key.L, Key.N);
                table.Add(Key.M, Key.C);
                table.Add(Key.N, Key.I);
                table.Add(Key.O, Key.F);
                table.Add(Key.P, Key.D);
                table.Add(Key.Q, Key.Y);
                table.Add(Key.R, Key.A);
                table.Add(Key.S, Key.W);
                table.Add(Key.T, Key.V);
                table.Add(Key.U, Key.E);
                table.Add(Key.V, Key.U);
                table.Add(Key.W, Key.S);
                table.Add(Key.X, Key.R);
                table.Add(Key.Y, Key.K);
                table.Add(Key.Z, Key.X);

                return table;
            }
        }

        public static RotorEncodingTable IIIC
        {
            get
            {
                RotorEncodingTable table = new RotorEncodingTable();
                table.Add(Key.A, Key.U);
                table.Add(Key.B, Key.Q);
                table.Add(Key.C, Key.N);
                table.Add(Key.D, Key.T);
                table.Add(Key.E, Key.L);
                table.Add(Key.F, Key.S);
                table.Add(Key.G, Key.Z);
                table.Add(Key.H, Key.F);
                table.Add(Key.I, Key.M);
                table.Add(Key.J, Key.R);
                table.Add(Key.K, Key.E);
                table.Add(Key.L, Key.H);
                table.Add(Key.M, Key.D);
                table.Add(Key.N, Key.P);
                table.Add(Key.O, Key.X);
                table.Add(Key.P, Key.K);
                table.Add(Key.Q, Key.I);
                table.Add(Key.R, Key.B);
                table.Add(Key.S, Key.V);
                table.Add(Key.T, Key.Y);
                table.Add(Key.U, Key.G);
                table.Add(Key.V, Key.J);
                table.Add(Key.W, Key.C);
                table.Add(Key.X, Key.W);
                table.Add(Key.Y, Key.O);
                table.Add(Key.Z, Key.A);

                return table;
            }
        }
    }
}