//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;

//namespace Belagricola.Infra
//{
//    public class Reflection
//    {
//        public enum Assemblies
//        {
//            Dados,
//            Dominio,
//            Infra,
//            Testes,
//            WindowsForms,
//            Nulo,
//        }

//        private static IEnumerable<Assembly> ObterListaDeAssemblies()
//        {
//            return AppDomain.CurrentDomain.GetAssemblies().Where(c => c.FullName.Contains("Belagricola"));
//        }

//        private static string ObterFullNameDoObjeto(string nomeDoObjeto, Assembly assembly)
//        {
//            return (from e in assembly.GetTypes()
//                    where e.Name == nomeDoObjeto
//                    select e.FullName).FirstOrDefault();
//        }

//        public static object ObterInstanciaDoObjeto(string nomeDoObjeto, Assemblies assemblyEnum)
//        {
//            var listaDeAssemblies = ObterListaDeAssemblies();

//            var assembly = listaDeAssemblies.Where(c => c.FullName.Contains(assemblyEnum.ToString()) 
//                || assemblyEnum == Assemblies.WindowsForms && c.GetName().Name == Assembly.GetEntryAssembly().GetName().Name).FirstOrDefault();
//            if (assembly == null)
//            {
//                throw new ArgumentException(string.Format("Não foi possível identificar o assembly {0}", assemblyEnum), "assemblyEnum");
//            }

//            var fullNameDoObjeto = ObterFullNameDoObjeto(nomeDoObjeto, assembly);
//            if (string.IsNullOrWhiteSpace(fullNameDoObjeto))
//            {
//                throw new ArgumentException(string.Format("Não foi possível identificar o objeto {0} no assembly {1}", nomeDoObjeto, assemblyEnum), "nomeDoObjeto");
//            }

//            return assembly.CreateInstance(fullNameDoObjeto);
//        }
//    }
//}

