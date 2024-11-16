using France;
using Env = System.Environment;
using Tx = Texas; // Tx becomes alias for the namespace and it is not imported.

Paris p1 = new();
Tx.Paris p2 = new();

WriteLine(Env.OSVersion);
WriteLine(Env.MachineName);
WriteLine(Env.CurrentDirectory);
