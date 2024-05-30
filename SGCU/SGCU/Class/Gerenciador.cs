using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGCU.Class
{
    public class Gerenciador
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public void CadastrarUsuario(Usuario usuario)
        {
            if (usuarios.Any(u => u.Codigo == usuario.Codigo))
            {
                AtualizarUsuario(usuario);
            }

            usuarios.Add(usuario);
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            var usuarioExistente = usuarios.FirstOrDefault(u => u.Codigo == usuario.Codigo);

            if (usuarioExistente == null)
            {
                throw new Exception("Usuário não encontrado");
            }

            usuarioExistente.Senha = usuario.Senha;
            usuarioExistente.Ativo = usuario.Ativo;
            usuarioExistente.Login = usuario.Login;
        }

        public List<Usuario> ListarUsuarios(int? codigo = null, string login = null, bool? status = null)
        {
            var usuariosFiltrados = usuarios;

            if (codigo != null)
            {
                usuariosFiltrados = usuariosFiltrados.Where(u => u.Codigo == codigo).ToList();
            }

            if (!string.IsNullOrEmpty(login))
            {
                usuariosFiltrados = usuariosFiltrados.Where(u => u.Login.Contains(login)).ToList();
            }

            if (status != null)
            {
                usuariosFiltrados = usuariosFiltrados.Where(u => u.Ativo == status).ToList();
            }

            return usuariosFiltrados;
        }

        private List<Unidade> unidades = new List<Unidade>();

        public void CadastrarUnidade(Unidade unidade)
        {
            if (unidades.Any(u => u.Id == unidade.Id))
            {
                AtualizarUnidade(unidade);
            }

            unidades.Add(unidade);
        }

        public void AtualizarUnidade(Unidade unidade)
        {
            var unidadeExistente = unidades.FirstOrDefault(u => u.Id == unidade.Id);

            if (unidadeExistente == null)
            {
                throw new Exception("Unidade não encontrado");
            }

            unidadeExistente.Nome = unidade.Nome;
            unidadeExistente.Ativa = unidade.Ativa;
            unidadeExistente.CodigoUnidade = unidade.CodigoUnidade;
        }

        public List<Unidade> ListarUnidades(int? Id = null, bool? status = null, string Nome = null)
        {
            var unidadesFiltradas = unidades;

            if (Id != null)
            {
                unidadesFiltradas = unidadesFiltradas.Where(u => u.Id == Id).ToList();
            }

            if (!string.IsNullOrEmpty(Nome))
            {
                unidadesFiltradas = unidadesFiltradas.Where(u => u.Nome.Contains(Nome)).ToList();
            }

            if (status != null)
            {
                unidadesFiltradas = unidadesFiltradas.Where(u => u.Ativa == status).ToList();
            }

            return unidadesFiltradas;
        }

        private List<Colaborador> colaboradores = new List<Colaborador>();

        public void CadastrarColaborador(Colaborador colaborador)
        {
            if (colaboradores.Any(c => c.Codigo == colaborador.Codigo))
            {
                AtualizarColaborador(colaborador);
            }
            colaboradores.Add(colaborador);
            throw new Exception("Colaborador cadastrado com sucesso.");
        }

        public void AtualizarColaborador(Colaborador colaborador)
        {
            var colaboradorExistente = colaboradores.FirstOrDefault(c => c.Codigo == colaborador.Codigo);
            if (colaboradorExistente == null)
            {
                throw new Exception("Colaborador não encontrado.");
            }
            colaboradorExistente.Nome = colaborador.Nome;
            colaboradorExistente.UnidadeAssociada = colaborador.UnidadeAssociada;
            colaboradorExistente.UsuarioAssociado = colaborador.UsuarioAssociado;
            throw new Exception("Colaborador atualizado com sucesso.");
        }

        public void RemoverColaborador(int codigo)
        {
            var colaborador = colaboradores.FirstOrDefault(c => c.Codigo == codigo);
            if (colaborador == null)
            {
                throw new Exception("Colaborador não encontrado.");
            }
            colaboradores.Remove(colaborador);
            throw new Exception("Colaborador removido com sucesso.");
        }

        public List<Colaborador> ListarColaboradores()
        {
            return colaboradores;
        }
    }
}
