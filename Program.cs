// Decompiled with JetBrains decompiler
// Type: WindowsFormsApplication1.Program
// Assembly: PBConfigEditorFinalVersion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FECF613A-B781-4A56-86B6-3D0456B5E18F
// Assembly location: E:\Projetos para RZBR\ragezoneBR.exe

using System;
using System.Windows.Forms;
using System.Data;

using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new index());
    }
  }
}
