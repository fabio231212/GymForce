using Capa.Datos;
using Capa.Entidades;
using Capa.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.BLL
{
    public class ConceptoLN : IConceptoLN
    {


        /// <summary>
        /// Método que actualiza actualiza el concepto
        /// </summary>
        /// <param name="concepto"></param>
        public void Actualizar(Concepto concepto)
        {
            IConceptoDB datos = new ConceptoDB();
            datos.Actualizar(concepto);
        }


        /// <summary>
        /// Método que elimina el concepto
        /// </summary>
        /// <param name="id"></param>
        public void Eliminar(int id)
        {
            IConceptoDB datos = new ConceptoDB();
            datos.Eliminar(id);
        }

        /// <summary>
        /// Método que calcula 
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public List<Concepto> GetConceptoByFiltro(string filtro)
        {
            IConceptoDB datos = new ConceptoDB();
            return datos.GetConceptoByFiltro(filtro);
        }


        /// <summary>
        /// Método que guarda concepto
        /// </summary>
        /// <param name="concepto"></param>
        public void Guardar(Concepto concepto)
        {
            IConceptoDB datos = new ConceptoDB();
            datos.Insertar(concepto);
        }


        /// <summary>
        /// Método que obtiene los concepto
        /// </summary>
        /// <returns></returns>
        public List<Concepto> ObtenerConceptos()
        {
            IConceptoDB datos = new ConceptoDB();
            return datos.SeleccionarTodas();
        }


        /// <summary>
        /// Método que obtiene los conceptos por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Concepto ObtenerConceptosPorId(int id)
        {
            IConceptoDB datos = new ConceptoDB();
           return  datos.SeleccionarPorId(id);
        }

        /// <summary>
        /// Método que actualiza la multa
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="precio"></param>
        public void UpdateConceptoMulta(int Id, double precio)
        {
            IConceptoDB datos = new ConceptoDB();
            datos.UpdateConceptoMulta(Id, precio);
        }
    }
}
