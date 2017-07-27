using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;

namespace WebAPI.Controllers.AppControllers
{
    public class UbicacionesController : ApiController
    {

        // GET: api/Ubicaciones
        public IHttpActionResult Get(DateTime fecha)
        {
            //HttpUtility.UrlEncode(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            //var url = "localhost:1941/api/ubicaciones?fecha=" + HttpUtility.UrlEncode(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            //DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


            //var ubicaciones = new[]{
            //                        #region ubicaciones
            //                        new  { lat = -31.4388610199289, lng = -68.5136067867279, nombre = "HOSPITAL JOSE GIORDANO", direccion = "Calle Sarmiento S/Nº..,", telefono = "4911002" ,ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.451138, lng= -68.403104, nombre= "HOSPITAL DR. ALFREDO RIZO ESPARZA", direccion= "DF SARMIENTO S/Nº", telefono= "4972018",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.327832853583537, lng= -69.41848754882812, nombre= "HOSPITAL  DR. ALDO  CANTONI", direccion= "AV. ARGENTINA S/Nº", telefono= "02648 421012",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.644166, lng= -69.471392, nombre= "HOSPITAL BARREAL", direccion= "LAS HERAS S/Nº", telefono= "02648 441060",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.53944397856179, lng= -68.51338148117065, nombre= "HOSPITAL DR. GUILLERMO RAWSON", direccion= "AV. RAWSON -SUR- 568", telefono= "0264 4227404/2272",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.650537, lng= -68.273837, nombre= "HOSPITAL DR. CESAR AGUILAR", direccion= "J. J. BUSTOS Y FERMIN RODRIGUEZ S/Nº", telefono= "4961110-4961032",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.187767, lng= -69.118225, nombre= "HOSPITAL TOMAS PERON", direccion= "SANTO DOMINGO S/Nº", telefono= "02647-493045",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.157002087161633, lng= -68.48503589630127, nombre= "HOSPITAL DE HUACO", direccion= "Calle San Martin S/N°", telefono= "02647-499933",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.235527, lng= -68.748334, nombre= "HOSPITAL SAN ROQUE", direccion= "25 DE MAYO E/ GRAL PAZ Y ABERASTAIN 859", telefono= "02647 420055",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.654367736505126, lng= -68.56347441673279, nombre= "HOSPITAL DR. FEDERICO CANTONI", direccion= "Av. Joaquin  Uñac  entre calle 10 y 11.", telefono= "4921052",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.53006178863218, lng= -68.59603643417358, nombre= "HOSPITAL DR MARCIAL V. QUIROGA", direccion= "AVDA.SAN MARTIN Y RASTREADOR CALIVAR 5499", telefono= "0264-4330880",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.517437, lng= -68.350531, nombre= "HOSPITAL DRA. STELLA MOLINA", direccion= "SARMIENTO Y MEGLIOLI S/Nº", telefono= "4971267             ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.984855516552862, lng= -68.42694997787476, nombre= "HOSPITAL DR. VENTURA LLOVERAS", direccion= "calle 25 DE MAYO S/Nº Villa Media Agua", telefono= "4941004",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.9533, lng= -68.6536, nombre= "HOSPITAL LOS BERROS", direccion= "RUTA PROVINCIAL  319 S/Nº", telefono= "4975122",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.6294, lng= -67.4654, nombre= "HOSPITAL DR. ALEJANDRO ALBARRACIN", direccion= "GRAL ACHA Y 25 DE MAYO S/Nº", telefono= "02646-420188",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.552152, lng= -68.653463, nombre= "HOSPITAL MENTAL EL ZONDA", direccion= "Ignacio de la Roza 8000 Oeste", telefono= "4212442",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.376063152751442, lng= -68.49889755249023, nombre= "CAPS EL RINCON", direccion= "El Rincón S/Nº. Obispo Zapata", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.402272, lng= -68.4689931, nombre= "CAPS LA CAÑADA", direccion= "Sarmiento entre Gral. Acha y Aberastain. La Cañada", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.405809929952255, lng= -68.49254608154297, nombre= "CAPS LAS LOMITAS", direccion= "La Laja 3850. Las Lomitas.", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.407156, lng= -68.384462, nombre= "CIC ANGACO", direccion= "Las Tapias S/Nº", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.41460027631321, lng= -68.51898193359375, nombre= "CAPS LAS TIERRITAS", direccion= "Calle Principal S/Nº. Las Tierritas", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.425075, lng= -68.445578, nombre= "CAPS CAMPO DE BATALLA", direccion= "Proyectada S/Nº Campo de Batalla", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.443089, lng= -68.283014, nombre= "CAPS EL BOSQUE", direccion= "El Bosque S/Nº", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.13407689018422, lng= -69.466552734375, nombre= "CAPS PUCHUZUN", direccion= "Ruta Provincial 412 Km 20. Puchuzun", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.464982360950497, lng= -69.4281005859375, nombre= "CAPS TAMBERIAS", direccion= "Alfonsina Storni S/Nº. Tamberías", telefono= "2648 492003",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.07190293438487, lng= -69.49007034301758, nombre= "CAPS VILLA NUEVA", direccion= "Ruta 20 Km 412. Villa Nueva", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.52242091711456, lng= -68.54896366596222, nombre= "CAPS ALFONSO BARASSI", direccion= "Matías Zavalla y San Lorenzo Bº Del Carmen", telefono= "4231922",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.51063601394296, lng= -68.52683544158936, nombre= "CAPS COMANDANTE CABOT", direccion= "Mary O Graham 56 Este Bº C. Cabot Concepción", telefono= "4276758",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.549418522407276, lng= -68.54716122150421, nombre= "CAPS LAS MARGARITAS", direccion= "Agustín Gomez esquina Juez Ramón Díaz. Villa del Carril", telefono= "4200214",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.61591666666, lng= -67.65105555555, nombre= "CAPS BERMEJO", direccion= "Ruta Nacional Km 14. Bermejo", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.6240422270494, lng= -68.31481218338013, nombre= "CAPS DR. RAUL ALFONSO FUEGO", direccion= "San Lorenzo y Torres S/Nº", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.665289803868568, lng= -68.3063793182373, nombre= "CAPS GUADALUPE", direccion= "Colon y Enfermera Medina El Rincon", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.490748764752368, lng= -67.357177734375, nombre= "CAPS LA PLANTA", direccion= "Escuela La Planta. Marayes", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.4620555555, lng= -67.35386111111, nombre= "CAPS MARAYES", direccion= "Ruta Nacional Km 51. Marayes", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.661404215495793, lng= -68.22389602661133, nombre= "CAPS PIE DE PALO", direccion= "San Lorenzo S/Nº. Cuadro Estación Pie de Palo", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.684716, lng= -68.263787, nombre= "CAPS POZO DE ALGARROBOS", direccion= "Paso de los Andes y Caseros. Pozo de los Algarrobos", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.591778, lng= -68.305321, nombre= "CAPS SAN AGUSTIN ROSCELLI", direccion= "Juan Lavalle S/Nº. La Puntilla", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.745102415233838, lng= -67.98545837402344, nombre= "CAPS VALLECITO", direccion= "Calle Principal S/Nº. Paraje Difunta Correa. Vallecito", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.62962, lng= -68.240725, nombre= "CAPS VIRGEN DE LA PAZ", direccion= "Rastreador Calívar S/Nº. Bº San Martín. Los Médanos", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.510681, lng= -68.589408, nombre= "CAPS COSTANERA NORTE", direccion= "Vidable S/Nº Bº Costanera.", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.505702727202152, lng= -68.5889184437027, nombre= "CAPS DR. JORGE HUMBERTO MIRA", direccion= "Rastreador Calívar S/Nº entre Arriero y Marucho. Villa Obrera", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.496700608235948, lng= -68.4761663009415, nombre= "CAPS FCO. GONZALEZ FERNANDEZ", direccion= "Av. Benavidez S/Nº. El Mogote", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.508195, lng= -68.523545, nombre= "CAPS JORGE RUIZ AGUILAR", direccion= "Fernandez Barrientos S/Nº. Barrio Independencia", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.501625, lng= -68.559493, nombre= "CAPS JOSE RUIZ", direccion= "René Favaloro y Tacuarí. Lote Hogar Nº 38", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.476577, lng= -68.487308, nombre= "CAPS MADRE TERESA DE CALCUTA", direccion= "Fernandez Barrientos S/Nº. Villa Videla. El Mogote", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.465082, lng= -68.518008, nombre= "CAPS MARIANO MORENO", direccion= "Ruta 40 y Calle 13 de Junio. Villa Mariano Moreno", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.509153, lng= -68.534394, nombre= "CAPS MONSEÑOR BAEZ LASPIUR", direccion= "Sarmiento y Lopez Pelaez. Villa El Salvador", telefono= "4315415",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.492776, lng= -68.533369, nombre= "CAPS RAMON CARRILLO", direccion= "Av Alem y 25 de Mayo", telefono= "4315454",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.507361403696645, lng= -68.5523271560669, nombre= "CAPS VILLA SAN PATRICIO", direccion= "Patagonia Oeste1617 y Tierney B° Los Tamarindos.", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.05557412659814, lng= -69.17426705360413, nombre= "CAPS ANGUALASTO", direccion= "Calle Principal S/Nº. Angualasto..", telefono= "*sin dato*",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.440386086566366, lng= -69.24545288085937, nombre= "CAPS BELLA VISTA", direccion= "La Laguna S/Nº.", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.18549602210943, lng= -69.10263061523437, nombre= "CAPS COLOLA", direccion= "Santo Domingo S/Nº. Colola", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.398937557618676, lng= -69.2138671875, nombre= "CAPS IGLESIA", direccion= "Calle Principal S/Nº. Villa Iglesia", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.323285680949706, lng= -69.20497298240662, nombre= "CAPS JUAN A. CARBAJAL", direccion= "Laprida S/Nº. Las Flores", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.322552, lng= -69.271067, nombre= "CAPS TUDCUM", direccion= "San Roque S/Nº", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.206861065952626, lng= -68.75518798828125, nombre= "CAPS ARBOL VERDE", direccion= "Tamberías. Jáchal", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.20270711497636, lng= -68.76068115234375, nombre= "CAPS EL MEDANO", direccion= "Alfonso Hernandez S/Nº.", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.22822147272595, lng= -68.64395141601562, nombre= "CAPS ENTRE RIOS", direccion= "Nueva Entre Rios S/Nº.", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.200926796606026, lng= -68.75175476074219, nombre= "CAPS GRAN CHINA", direccion= "Gran China S/Nº", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.67571540416773, lng= -68.367919921875, nombre= "CAPS MOGNA", direccion= "Argentina y Proyectada S/Nº. Mogna", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.410099, lng= -68.689325, nombre= "CAPS NIQUIVIL", direccion= "Ruta Nacional Nº 40 y Centenario", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.176889347682454, lng= -68.719482421875, nombre= "CAPS PAMPA DE CHAÑAR", direccion= "Noriega S/Nº. Pampa del Chañar", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.17777972817965, lng= -68.80874633789062, nombre= "CAPS PAMPA VIEJA", direccion= "Varas S/Nº", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.23771349789205, lng= -68.55880737304687, nombre= "CAPS SAN ISIDRO", direccion= "San Isidro", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.285938, lng= -68.708757, nombre= "CAPS SAN ROQUE DE JACHAL", direccion= "Ruta Provincial 472 S/Nº.", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.23118782903468, lng= -68.82041931152344, nombre= "CAPS TAMBERIAS", direccion= "Tamberías.", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.146908510079008, lng= -68.65562438964844, nombre= "CAPS VILLA MERCEDES", direccion= "Eugenio Flores S/Nº", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.6970060, lng= -68.389170, nombre= "CAPS ARTURO CABRAL DE LA COLINA", direccion= "Diagonal San Martín e Ignacio de la Roza S/Nº Vº 9 de Julio", telefono= "4977092             ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.593782, lng= -68.407798, nombre= "CAPS DR. CARLOS BOUTHERY", direccion= "Ruta 20 Km 14. Las Chacritas", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.703086, lng= -68.590650, nombre= "CAPS ALDO HERMOSILLA", direccion= "Aberastain entre calles 14 y 15. La Rinconada", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.61063008404481, lng= -68.60326766967773, nombre= "CAPS ALONSO FUEGO", direccion= "Costa Canal y Calle 8. Quinto Cuartel", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.748166, lng= -68.556952, nombre= "CAPS BARRIO MUNICIPAL", direccion= "Mendoza entre calle 18 y callejón Frau 8273..", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.819206, lng= -68.541783, nombre= "CAPS CHUBUT", direccion= "2 de Abril (Ruta 40 y Anacleto Gil Km 32). Barrio Chubut", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.8594, lng= -68.5366, nombre= "CAPS DR M BRACCO", direccion= "Ruta 40 y calle Cantoni Mzna 6. Bº El Cerrillo", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.682059, lng= -68.517856, nombre= "CAPS JOAQUIN UÑAC", direccion= "Alfonso XIII y calle 12", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.591550082840896, lng= -68.56636047363281, nombre= "CAPS LOTE HOGAR Nº 27", direccion= "Vidart entre calles 5 y 6. Bº Lote Hogar Nº 27. Quinto Cuartel", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.572132, lng= -68.529974, nombre= "CAPS VILLA CONSTITUCION", direccion= "Lemos S/Nº entre calles 5 y 6. Villa Constitución", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.593965, lng= -68.528455, nombre= "CAPS VILLA HUARPES", direccion= "Aberastain y J.J. Bustos. Villa Huarpes", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.593263, lng= -68.542600, nombre= "CAPS VILLA PAOLINI", direccion= "Alvear e Independencia. Villa Paolini", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.623311369870308, lng= -68.49303960800171, nombre= "CAPS BARRIO BUBICA", direccion= "E. Palma y Miguel Bernal S/Nº. Bº Bubica. Medanito", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.567200958823936, lng= -68.53962421417236, nombre= "CAPS CAPITAN LAZO", direccion= "San Martín y Misiones 280. Barrio Capitán Lazo", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.573452, lng= -68.529032, nombre= "CAPS CENTRO DE ADIESTRAMIENTO DR RENE FAVALORO", direccion= "T del Fuego y Fermín Rodriguez Bº Residencial Rawson", telefono= "0264 - 4240924      ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.608392, lng= -68.513189, nombre= "CAPS COLONIA RODAS", direccion= "España y Tascheret S/Nº. Colonia Rodas", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.620677, lng= -68.46262, nombre= "CAPS CRISTO REY", direccion= "Calle 5 entre Punta del Monte y América. Médano de Oro", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.561642909963183, lng= -68.54988098144531, nombre= "CAPS DR. ELIO CANTONI", direccion= "Recuerdos de Provincia 1618 Oeste. Villa Hipódromo", telefono= "4340312             ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.558936897874887, lng= -68.56091022491455, nombre= "CAPS MARTIN GUEMES", direccion= "Velez Sarsfield y Capdevilla 402. Barrio Güemes", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.582168, lng= -68.558926, nombre= "CAPS MAURIN NAVARRO", direccion= "Alvarez Condarco y Félix Aguilar. Bº Buenaventura Luna.", telefono= "4343448             ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.643362, lng= -68.500091, nombre= "CAPS MEDANO DE ORO", direccion= "Belgrano y calle 8. Médano de Oro", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.574461, lng= -68.550849, nombre= "CAPS MONSEÑOR DI STEFANO", direccion= "Frías y Franklin 1240 Oeste. Bº La Estación", telefono= "4343940             ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.583251, lng= -68.532452, nombre= "CAPS 12 DE OCTUBRE", direccion= "Progreso y Chacabuco. Bº San Ricardo. Villa Krawse", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.51785255714755, lng= -68.56418251991272, nombre= "CAPS Bº ARAMBURU", direccion= "Plumerillo y Bazan Agras. Paula Albarracin Oeste. Bº Aramburu", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.519427, lng= -68.574014, nombre= "CAPS BARRIO HUAZIHUL", direccion= "Sargento Cabral 393 Oeste. Barrio Huazihul", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.551642, lng= -68.565826, nombre= "CAPS DOCENTES SANJUANINOS", direccion= "Sargento Acosta S/Nº sur Sector 3 Mzna 3. Bº UDAP III.", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.551376, lng= -68.551508, nombre= "CAPS DR RENE FAVALORO (B RIVADAVIA SUR)", direccion= "Las Heras 1159 Oeste. Bº Rivadavia.", telefono= "4343987             ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.539705, lng= -68.616779, nombre= "CAPS LA BEBIDA", direccion= "Ignacio de la Roza 4258 Oeste. La Bebida.", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.538827, lng= -68.632585, nombre= "CAPS LOTE HOGAR Nº 3", direccion= "Entre Atencio Ignacio de la Rozay Morón. Lote Hogar 3. La Bebida.", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.526442, lng= -68.632387, nombre= "CAPS MATERNO INFANTIL DOMINGA RAIMUNDO", direccion= "Av.Libertador San Martin y Galindez-Marquesado - RIVADAVIA.", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.512900, lng= -68.580822, nombre= "CAPS RIVADAVIA NORTE", direccion= "Cano y Larralde S/Nº. Bº Rivadavia Norte.", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.536094, lng= -68.569451, nombre= "CAPS RODRIGUEZ PINTO", direccion= "Centenario 627 Sur. Villa Rodriguez Pinto", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.51987382104273, lng= -68.61923217773437, nombre= "CAPS ROLANDO CONTURSO (LOTE HOGAR N 53)", direccion= "Proyectada S/Nº. Unición Vecinal Lote Hogar Nº 53. Marquesado.", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.551915527480208, lng= -68.62747192382812, nombre= "CAPS SAN JUSTO", direccion= "Proyectada S/Nº. Bº Bernardino Rivadavia. La Bebida.", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.506128392881433, lng= -68.3311253786087, nombre= "CAPS BARRIO INDEPENDENCIA", direccion= "Barrio Independencia San Isidro", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.558410, lng= -68.300675, nombre= "CAPS EJERCITO DE LOS ANDES", direccion= "Independencia S/Nº. Villa Dominguito", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.5108, lng= -68.4647, nombre= "CAPS DR EMILIO GALDEANO", direccion= "Balcarce y Av Nueva Argentina S/Nº Colonia Gutierrez", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.53787120158133, lng= -68.41804504394531, nombre= "CAPS DR. HORACIO ANTONIO GRILLO", direccion= "Av Libertador 6236 Este. Alto de Sierra", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.5339, lng= -68.4739, nombre= "CAPS VILLA DON ARTURO", direccion= "Av. Libertador 4071 Este", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.5443, lng= -68.4948, nombre= "CAPS VILLA MARIA", direccion= "Los Almendros 2314 Bº Cooperativa Villa María", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.5217, lng= -68.501, nombre= "CAPS VILLA MARINI", direccion= "San Lorenzo 1137 Este. Villa Marini", telefono= "4214044             ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.9857, lng= -68.549, nombre= "CAPS CAÑADA HONDA", direccion= "Ruta 318 S/Nº. Cañada Honda", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.9022, lng= -68.469, nombre= "CAPS CERRO VALDIVIA", direccion= "Salvador María del Carril S/Nº. Colonia Fiscal", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -32.0721, lng= -68.6923, nombre= "CAPS CIENAGUITA", direccion= "Ing. Adolfo Casale S/Nº. Cienaguita", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.9131, lng= -68.3744, nombre= "CAPS COCHAGUAL CENTRO", direccion= "Carmona. Escuela Juan Pablo II. Cochagual", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.878, lng= -68.3842, nombre= "CAPS COCHAGUAL NORTE", direccion= "Ruta Provincial 253. Cochagual", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -32.0095, lng= -68.6926, nombre= "CAPS DIVISADERO", direccion= "Ing. Adolfo Casale S/Nº (Unión Vecinal). Divisadero", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -32.0641, lng= -68.5905, nombre= "CAPS GUANACACHE", direccion= "Buenos Aires S/Nº. Escuela Olegario Andrade. Guanacache", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.9654, lng= -68.3219, nombre= "CAPS LA CILVICA", direccion= "Avellaneda (Escuela G. C. Vigil). Cochagual", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -32.0435, lng= -68.3696, nombre= "CAPS LAS LAGUNAS", direccion= "Mzna A Casa 5. Bº Las Lagunas", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -32.1849, lng= -68.7515, nombre= "CAPS PEDERNAL", direccion= "Calle Principal S/Nº. Unión Vecinal. Pedernal", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.8947, lng= -68.4194, nombre= "CAPS PUNTA DEL MEDANO", direccion= "Ruta km 295 y Ruta 253. Punta del Médano", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -32.0933, lng= -68.6191, nombre= "CAPS RETAMITO", direccion= "Ing. Adolfo Casale (Escuela). Retamito", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -32.145385562629315, lng= -68.49151611328125, nombre= "CAPS SAN CARLOS", direccion= "Ruta Nacional 40. San Carlos", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -32.05027987804489, lng= -68.41529846191406, nombre= "CAPS TRES ESQUINAS", direccion= "calle 25 de Mayo entre Carpino y Aranda. Barrio Tres Esquina", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.4768, lng= -68.751, nombre= "CAPS ALEJANDRO ROYON", direccion= "Proyectada S/Nº. Villa Santa Rosa. Villa Aurora", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.4584, lng= -68.7179, nombre= "CAPS ULLUM", direccion= "Valentín Ruiz S/Nº. Villa Ibañez", telefono= "4943008             ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.59891181819194, lng= -67.48077392578125, nombre= "CAPS AGUA CERCADA", direccion= "Ruta 510. Agua Cercada", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.9539, lng= -67.3039, nombre= "CAPS ASTICA", direccion= "Fabián Atencio S/Nº", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.9336, lng= -67.2502, nombre= "CAPS BALDE DE ASTICA", direccion= "Camino Comunal. Baldes de Astica", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.654452824400724, lng= -67.5, nombre= "CAPS BALDE DE FUNES", direccion= "Camino Comunal S/Nº. Balde de Funes", telefono= "00000               ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.6425, lng= -67.4022, nombre= "CAPS BALDE DE LAS CHILCAS", direccion= "Ruta 510 S/Nº. Balde de las Chilcas", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.3248, lng= -67.6958, nombre= "CAPS BALDE DEL ROSARIO", direccion= "Ruta 510 S/Nº. Balde del Rosario", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.10233357287178, lng= -67.29537963867187, nombre= "CAPS BALDE DEL SUR DE CHUCUMA", direccion= "Camino Comunal S/Nº. Balde de Chucuma", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.2181, lng= -67.6966, nombre= "CAPS BALDECITOS", direccion= "Ruta 510. Baldecitos", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.0711, lng= -67.2766, nombre= "CAPS CHUCUMA", direccion= "Ruta 510 S/Nº Chucuma", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.360730119782584, lng= -67.65689849853515, nombre= "CAPS LA MAJADITA", direccion= "Camino Comunal S/Nº. La Majadita", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.702877445958027, lng= -67.41622924804687, nombre= "CAPS LOS BRETES", direccion= "Camino Comunal S/Nº. Los Bretes", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.440386086566366, lng= -67.54806518554687, nombre= "CAPS SEGUNDO T ELIZONDO (SIERRAS DE CHAVEZ)", direccion= "Camino Comunal S/Nº. Sierras de Chavez", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.426177145763013, lng= -67.58514404296875, nombre= "CAPS SIERRAS DE ELIZONDO", direccion= "Camino Comunal S/Nº. Sierras de Elizondo", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.37405999207124, lng= -67.6153564453125, nombre= "CAPS SIERRAS DE RIVEROS", direccion= "Sierras de Riveros", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.5661, lng= -67.54, nombre= "CAPS USNO", direccion= "Ruta 510 S/Nº.", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -32.0361, lng= -68.2101, nombre= "CAPS DOMINGO RAMON CEJAS", direccion= "Mariano Moreno s/Nº. Las Casuarinas", telefono= "4974045             ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -32.00137975782923, lng= -68.04485321044922, nombre= "CAPS EL ENCON", direccion= "Ruta 20 S/Nº. Bº Juan Albarracín.", telefono= "4200201             ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.8359, lng= -68.3545, nombre= "CAPS LA CHIMBERA", direccion= "Ruperto Martín S/Nº. La Chimbera", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.596914, lng= -68.273919, nombre= "CAPS LAS TRANCAS", direccion= "Ruta 20 S/Nº. Las Trancas", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.73400724374667, lng= -68.2661247253418, nombre= "CAPS PASCUAL CHENA", direccion= "Calle 2 y 22. Santa Rosa", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.85656420395222, lng= -68.24226379394531, nombre= "CAPS PUNTA DEL AGUA", direccion= "Escuela Federico Magio. Punta del Agua", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.8274, lng= -68.2461, nombre= "CAPS SANTA ROSA", direccion= "25 de Mayo y Mitre S/Nº.", telefono= "4978014             ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.8132, lng= -68.3285, nombre= "CAPS TUPELI", direccion= "Bº Seru. Tupelí", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.75064950256234, lng= -68.236083984375, nombre= "CAPS VILLA LA SALUD", direccion= "calle 3 entre calles 24 y 25. Villa El Tango", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.5533, lng= -68.7294, nombre= "CAPS ZONDA", direccion= "Ruta 20 4165. Villa Basilio Nievas", telefono= "4945003             ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.333533087054338, lng= -69.42097663879395, nombre= "CAPS SOROCAYENSE", direccion= "Av Presidente Roca S/Nº. Sorocayense (Rutas 406 y 412)", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -30.18549602210943, lng= -68.73458862304687, nombre= "CAPS TRES ESQUINAS", direccion= "Euguenio Flores S/n   - Tres esquinas", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.50792852318234, lng= -68.50829601287842, nombre= "CAPS VILLA ALBA", direccion= "J.j. Urquiza 1486. Villa Urquiza", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.5007, lng= -68.5121, nombre= "CIC - BARRIO LOS ANDES", direccion= "Patagonia y Greco. Barrio Los Andes", telefono= "4315856             ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.752, lng= -68.3121, nombre= "CIC 25 DE MAYO", direccion= "Ruta 270 entre 4 y 5. Bº Algarrobo Verde", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.428, lng= -68.4956, nombre= "CIC ALBARDON", direccion= "La Laja esquina Nacional S/Nº.", telefono= "4912046             ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.408248857678068, lng= -68.39176464424132, nombre= "CAPS LAS TAPIAS", direccion= "21 DE FEBRERO E/ NACIONAL Y OLIVERA S/Nº", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.424396879298164, lng= -68.54054689407348, nombre= "CIC FRANCISCO GIULANO (EX CAMPO AFUERA)", direccion= "Juan Lahoz y Proyectada.", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.550452675471497, lng= -68.30483436584473, nombre= "CIC LA PUNTILLA (CAPS ARNOLDO JANSSEN)", direccion= "Calle 20 de Junio y Florida. La Puntilla", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.629560013457468, lng= -68.47949981689453, nombre= "CIC MEDANO DE ORO", direccion= "Ramón Franco pasando calle 6.", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.5923, lng= -68.5489, nombre= "CIC POCITO", direccion= "Lemos y Prolongación Picasso. Bº Salvador Norte", telefono= "4283275             ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.487381967265797, lng= -68.41667175292969, nombre= "CIC SAN MARTIN", direccion= "Nacional entre Rodriguez y Quiroga", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.981279118769915, lng= -68.42704653739929, nombre= "CIC SARMIENTO", direccion= "calle 9 de Julio. Parrio Pagonia I.", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.465421620445546, lng= -68.73518943786621, nombre= "CIC ULLUM", direccion= "Ullampa y Luján. Bº Ullum II", telefono= "4943382             ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.562512741611812, lng= -68.56220641247779, nombre= "CIC VILLA ANGELICA", direccion= "Bahía Blanca y Paso de los Andes. Villa Ángélica.", telefono= "4340611             ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
            //                        new  { lat= -31.545415, lng= -68.732691, nombre= "CIC ZONDA", direccion= "Manuel  Andujar  s / nº", telefono= "*sin dato*          ",ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},}.ToList();
            //#endregion


            //#region ubicaciones2
            var ubicaciones2 = new[]{
                new {  nombre= "CAPS EL RINCON", latitud= -31.487381967265797,longitud= -68.49254608154297,telefono= "*sin dato*",direccion= "La Laja 3850. Las Lomitas.",depto= 442,ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg" },
                new {  nombre= "CAPS LA CAÑADA", latitud= -31.402272,longitud= -68.49254608154297,telefono= "*sin dato*",direccion= "La Laja 3850. Las Lomitas.",depto= 442,ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"},
                new {
                 nombre = "CAPS LAS LOMITAS",
                latitud = -31.405809929952255,
                longitud = -68.49254608154297,
                telefono = "*sin dato*",
                direccion = "La Laja 3850. Las Lomitas.",
                depto = 442,
                ImgUrl = "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            }, 



            new {
                          nombre= "CAPS LAS TIERRITAS",
              latitud= -31.41460027631321,
              longitud= -68.51898193359375,
              telefono= "*sin dato*",
              direccion= "Calle Principal S/Nº. Las Tierritas",
              depto= 442,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS CAMPO DE BATALLA",
              latitud= -31.425075,
              longitud= -68.445578,
              telefono= "*sin dato*",
              direccion= "Proyectada S/Nº Campo de Batalla",
              depto= 443,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS EL BOSQUE",
              latitud= -31.443089,
              longitud= -68.283014,
              telefono= "*sin dato*",
              direccion= "El Bosque S/Nº",
              depto= 443,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS PUCHUZUN",
              latitud= -31.13407689018422,
              longitud= -69.466552734375,
              telefono= "*sin dato*",
              direccion= "Ruta Provincial 412 Km 20. Puchuzun",
              depto= 441,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS TAMBERIAS",
              latitud= -31.464982360950497,
              longitud= -69.4281005859375,
              telefono= "2648 492003",
              direccion= "Alfonsina Storni S/Nº. Tamberías",
              depto= 441,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS VILLA NUEVA",
              latitud= -31.07190293438487,
              longitud= -69.49007034301758,
              telefono= "*sin dato*",
              direccion= "Ruta 20 Km 412. Villa Nueva",
              depto= 441,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new
            {
                nombre = "CAPS ALFONSO BARASSI",
                latitud = -31.52242091711456,
                longitud = -68.54896366596222,
                telefono = "4231922",
                direccion = "Matías Zavalla y San Lorenzo Bº Del Carmen",
                depto = 439,
                ImgUrl = "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS COMANDANTE CABOT",
              latitud= -31.51063601394296,
              longitud= -68.52683544158936,
              telefono= "4276758",
              direccion= "Mary O Graham 56 Este Bº C. Cabot Concepción",
              depto= 439,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS LAS MARGARITAS",
              latitud= -31.549418522407276,
              longitud= -68.54716122150421,
              telefono= "4200214",
              direccion= "Agustín Gomez esquina Juez Ramón Díaz. Villa del Carril",
              depto= 439,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "INSTITUTO ODONTOLOGICO DR.CAYETANO TORCIVIA",
              latitud= -31.535969203326232,
              longitud= -68.51700782775879,
              telefono= "0264-4222525",
              direccion= "Rivadavia Este 688 - Capital",
              depto= 439,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS BERMEJO",
              latitud= -31.61591666666,
              longitud= -67.65105555555,
              telefono= "*sin dato*",
              direccion= "Ruta Nacional Km 14. Bermejo",
              depto= 440,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS DR. RAUL ALFONSO FUEGO",
              latitud= -31.6240422270494,
              longitud= -68.31481218338013,
              telefono= "*sin dato*",
              direccion= "San Lorenzo y Torres S/Nº",
              depto= 440,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS GUADALUPE",
              latitud= -31.665289803868568,
              longitud= -68.3063793182373,
              telefono= "*sin dato*",
              direccion= "Colon y Enfermera Medina El Rincon",
              depto= 440,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS LA PLANTA",
              latitud= -31.490748764752368,
              longitud= -67.357177734375,
              telefono= "*sin dato*",
              direccion= "Escuela La Planta. Marayes",
              depto= 440,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS MARAYES",
              latitud= -31.4620555555,
              longitud= -67.35386111111,
              telefono= "*sin dato*",
              direccion= "Ruta Nacional Km 51. Marayes",
              depto= 440,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS PIE DE PALO",
              latitud= -31.661404215495793,
              longitud= -68.22389602661133,
              telefono= "*sin dato*",
              direccion= "San Lorenzo S/Nº. Cuadro Estación Pie de Palo",
              depto= 440,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS POZO DE ALGARROBOS",
              latitud= -31.684716,
              longitud= -68.263787,
              telefono= "*sin dato*",
              direccion= "Paso de los Andes y Caseros. Pozo de los Algarrobos",
              depto= 440,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS SAN AGUSTIN ROSCELLI",
              latitud= -31.591778,
              longitud= -68.305321,
              telefono= "*sin dato*",
              direccion= "Juan Lavalle S/Nº. La Puntilla",
              depto= 440,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS VALLECITO",
              latitud= -31.745102415233838,
              longitud= -67.98545837402344,
              telefono= "*sin dato*",
              direccion= "Calle Principal S/Nº. Paraje Difunta Correa. Vallecito",
              depto= 440,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS VIRGEN DE LA PAZ",
              latitud= -31.62962,
              longitud= -68.240725,
              telefono= "*sin dato*",
              direccion= "Rastreador Calívar S/Nº. Bº San Martín. Los Médanos",
              depto= 440,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS COSTANERA NORTE",
              latitud= -31.510681,
              longitud= -68.589408,
              telefono= "*sin dato*",
              direccion= "Vidable S/Nº Bº Costanera.",
              depto= 437,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS DR. JORGE HUMBERTO MIRA",
              latitud= -31.505702727202152,
              longitud= -68.5889184437027,
              telefono= "*sin dato*",
              direccion= "Rastreador Calívar S/Nº entre Arriero y Marucho. Villa Obrera",
              depto= 437,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS FCO. GONZALEZ FERNANDEZ",
              latitud= -31.496700608235948,
              longitud= -68.4761663009415,
              telefono= "*sin dato*",
              direccion= "Av. Benavidez S/Nº. El Mogote",
              depto= 437,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS JORGE RUIZ AGUILAR",
              latitud= -31.508195,
              longitud= -68.523545,
              telefono= "*sin dato*",
              direccion= "Fernandez Barrientos S/Nº. Barrio Independencia",
              depto= 437,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS JOSE RUIZ",
              latitud= -31.501625,
              longitud= -68.559493,
              telefono= "*sin dato*",
              direccion= "René Favaloro y Tacuarí. Lote Hogar Nº 38",
              depto= 437,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS MADRE TERESA DE CALCUTA",
              latitud= -31.476577,
              longitud= -68.487308,
              telefono= "*sin dato*",
              direccion= "Fernandez Barrientos S/Nº. Villa Videla. El Mogote",
              depto= 437,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS MARIANO MORENO",
              latitud= -31.465082,
              longitud= -68.518008,
              telefono= "*sin dato*",
              direccion= "Ruta 40 y Calle 13 de Junio. Villa Mariano Moreno",
              depto= 437,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS MONSEÑOR BAEZ LASPIUR",
              latitud= -31.509153,
              longitud= -68.534394,
              telefono= "4315415",
              direccion= "Sarmiento y Lopez Pelaez. Villa El Salvador",
              depto= 437,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS RAMON CARRILLO",
              latitud= -31.492776,
              longitud= -68.533369,
              telefono= "4315454",
              direccion= "Av Alem y 25 de Mayo",
              depto= 437,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS VILLA SAN PATRICIO",
              latitud= -31.507361403696645,
              longitud= -68.5523271560669,
              telefono= "*sin dato*",
              direccion= "Patagonia Oeste1617 y Tierney B° Los Tamarindos.",
              depto= 437,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS ANGUALASTO",
              latitud= -30.05557412659814,
              longitud= -69.17426705360413,
              telefono= "*sin dato*",
              direccion= "Calle Principal S/Nº. Angualasto..",
              depto= 438,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                         nombre= "CAPS BELLA VISTA",
              latitud= -30.440386086566367,
              longitud= -69.24545288085938,
              telefono= "*sin dato*",
              direccion= "La Laguna S/Nº.",
              depto= 438,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS COLOLA",
              latitud= -30.18549602210943,
              longitud= -69.10263061523438,
              telefono= "*sin dato*",
              direccion= "Santo Domingo S/Nº. Colola",
              depto= 438,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS IGLESIA",
              latitud= -30.398937557618677,
              longitud= -69.2138671875,
              telefono= "*sin dato*",
              direccion= "Calle Principal S/Nº. Villa Iglesia",
              depto= 438,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS JUAN A. CARBAJAL",
              latitud= -30.323285680949706,
              longitud= -69.20497298240662,
              telefono= "*sin dato*",
              direccion= "Laprida S/Nº. Las Flores",
              depto= 438,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS TUDCUM",
              latitud= -30.322552,
              longitud= -69.271067,
              telefono= "*sin dato*",
              direccion= "San Roque S/Nº",
              depto= 438,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS ARBOL VERDE",
              latitud= -30.206861065952626,
              longitud= -68.75518798828125,
              telefono= "*sin dato*",
              direccion= "Tamberías. Jáchal",
              depto= 435,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS EL MEDANO",
              latitud= -30.20270711497636,
              longitud= -68.76068115234375,
              telefono= "*sin dato*",
              direccion= "Alfonso Hernandez S/Nº.",
              depto= 435,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS ENTRE RIOS",
              latitud= -30.22822147272595,
              longitud= -68.64395141601562,
              telefono= "*sin dato*",
              direccion= "Nueva Entre Rios S/Nº.",
              depto= 435,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS GRAN CHINA",
              latitud= -30.200926796606026,
              longitud= -68.75175476074219,
              telefono= "*sin dato*",
              direccion= "Gran China S/Nº",
              depto= 435,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS MOGNA",
              latitud= -30.67571540416773,
              longitud= -68.367919921875,
              telefono= "*sin dato*",
              direccion= "Argentina y Proyectada S/Nº. Mogna",
              depto= 435,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS NIQUIVIL",
              latitud= -30.410099,
              longitud= -68.689325,
              telefono= "*sin dato*",
              direccion= "Ruta Nacional Nº 40 y Centenario",
              depto= 435,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS PAMPA DE CHAÑAR",
              latitud= -30.176889347682454,
              longitud= -68.719482421875,
              telefono= "*sin dato*",
              direccion= "Noriega S/Nº. Pampa del Chañar",
              depto= 435,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS PAMPA VIEJA",
              latitud= -30.17777972817965,
              longitud= -68.80874633789062,
              telefono= "*sin dato*",
              direccion= "Varas S/Nº",
              depto= 435,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS SAN ISIDRO",
              latitud= -30.23771349789205,
              longitud= -68.55880737304688,
              telefono= "*sin dato*",
              direccion= "San Isidro",
              depto= 435,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS SAN ROQUE DE JACHAL",
              latitud= -30.285938,
              longitud= -68.708757,
              telefono= "*sin dato*",
              direccion= "Ruta Provincial 472 S/Nº.",
              depto= 435,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS TAMBERIAS",
              latitud= -30.23118782903468,
              longitud= -68.82041931152344,
              telefono= "*sin dato*",
              direccion= "Tamberías.",
              depto= 435,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS VILLA MERCEDES",
              latitud= -30.146908510079008,
              longitud= -68.65562438964844,
              telefono= "*sin dato*",
              direccion= "Eugenio Flores S/Nº",
              depto= 435,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS ARTURO CABRAL DE LA COLINA",
              latitud= -31.697006,
              longitud= -68.38917,
              telefono= "4977092",
              direccion= "Diagonal San Martín e Ignacio de la Roza S/Nº Vº 9 de Julio",
              depto= 436,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS DR. CARLOS BOUTHERY",
              latitud= -31.593782,
              longitud= -68.407798,
              telefono= "*sin dato*",
              direccion= "Ruta 20 Km 14. Las Chacritas",
              depto= 436,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS ALDO HERMOSILLA",
              latitud= -31.703086,
              longitud= -68.59065,
              telefono= "*sin dato*",
              direccion= "Aberastain entre calles 14 y 15. La Rinconada",
              depto= 434,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS ALONSO FUEGO",
              latitud= -31.61063008404481,
              longitud= -68.60326766967773,
              telefono= "*sin dato*",
              direccion= "Costa Canal y Calle 8. Quinto Cuartel",
              depto= 434,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS BARRIO MUNICIPAL",
              latitud= -31.748166,
              longitud= -68.556952,
              telefono= "*sin dato*",
              direccion= "Mendoza entre calle 18 y callejón Frau 8273..",
              depto= 434,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS CHUBUT",
              latitud= -31.819206,
              longitud= -68.541783,
              telefono= "*sin dato*",
              direccion= "2 de Abril (Ruta 40 y Anacleto Gil Km 32). Barrio Chubut",
              depto= 434,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS DR M BRACCO",
              latitud= -31.8594,
              longitud= -68.5366,
              telefono= "*sin dato*",
              direccion= "Ruta 40 y calle Cantoni Mzna 6. Bº El Cerrillo",
              depto= 434,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS JOAQUIN UÑAC",
              latitud= -31.682059,
              longitud= -68.517856,
              telefono= "*sin dato*",
              direccion= "Alfonso XIII y calle 12",
              depto= 434,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS LOTE HOGAR Nº 27",
              latitud= -31.591550082840897,
              longitud= -68.56636047363281,
              telefono= "*sin dato*",
              direccion= "Vidart entre calles 5 y 6. Bº Lote Hogar Nº 27. Quinto Cuartel",
              depto= 434,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS VILLA CONSTITUCION",
              latitud= -31.572132,
              longitud= -68.529974,
              telefono= "*sin dato*",
              direccion= "Lemos S/Nº entre calles 5 y 6. Villa Constitución",
              depto= 434,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS VILLA HUARPES",
              latitud= -31.593965,
              longitud= -68.528455,
              telefono= "*sin dato*",
              direccion= "Aberastain y J.J. Bustos. Villa Huarpes",
              depto= 434,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS VILLA PAOLINI",
              latitud= -31.593263,
              longitud= -68.5426,
              telefono= "*sin dato*",
              direccion= "Alvear e Independencia. Villa Paolini",
              depto= 434,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS BARRIO BUBICA",
              latitud= -31.623311369870308,
              longitud= -68.49303960800171,
              telefono= "*sin dato*",
              direccion= "E. Palma y Miguel Bernal S/Nº. Bº Bubica. Medanito",
              depto= 433,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS CAPITAN LAZO",
              latitud= -31.567200958823936,
              longitud= -68.53962421417236,
              telefono= "*sin dato*",
              direccion= "San Martín y Misiones 280. Barrio Capitán Lazo",
              depto= 433,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS CENTRO DE ADIESTRAMIENTO DR RENE FAVALORO",
              latitud= -31.573452,
              longitud= -68.529032,
              telefono= "0264 - 4240924",
              direccion= "T del Fuego y Fermín Rodriguez Bº Residencial Rawson",
              depto= 433,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS COLONIA RODAS",
              latitud= -31.608392,
              longitud= -68.513189,
              telefono= "*sin dato*",
              direccion= "España y Tascheret S/Nº. Colonia Rodas",
              depto= 433,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS CRISTO REY",
              latitud= -31.620677,
              longitud= -68.46262,
              telefono= "*sin dato*",
              direccion= "Calle 5 entre Punta del Monte y América. Médano de Oro",
              depto= 433,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS DR. ELIO CANTONI",
              latitud= -31.561642909963183,
              longitud= -68.54988098144531,
              telefono= "4340312",
              direccion= "Recuerdos de Provincia 1618 Oeste. Villa Hipódromo",
              depto= 433,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS MARTIN GUEMES",
              latitud= -31.558936897874887,
              longitud= -68.56091022491455,
              telefono= "*sin dato*",
              direccion= "Velez Sarsfield y Capdevilla 402. Barrio Güemes",
              depto= 433,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS MAURIN NAVARRO",
              latitud= -31.582168,
              longitud= -68.558926,
              telefono= "4343448",
              direccion= "Alvarez Condarco y Félix Aguilar. Bº Buenaventura Luna.",
              depto= 433,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS MEDANO DE ORO",
              latitud= -31.643362,
              longitud= -68.500091,
              telefono= "*sin dato*",
              direccion= "Belgrano y calle 8. Médano de Oro",
              depto= 433,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS MONSEÑOR DI STEFANO",
              latitud= -31.574461,
              longitud= -68.550849,
              telefono= "4343940",
              direccion= "Frías y Franklin 1240 Oeste. Bº La Estación",
              depto= 433,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS 12 DE OCTUBRE",
              latitud= -31.583251,
              longitud= -68.532452,
              telefono= "*sin dato*",
              direccion= "Progreso y Chacabuco. Bº San Ricardo. Villa Krawse",
              depto= 433,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS Bº ARAMBURU",
              latitud= -31.51785255714755,
              longitud= -68.56418251991272,
              telefono= "*sin dato*",
              direccion= "Plumerillo y Bazan Agras. Paula Albarracin Oeste. Bº Aramburu",
              depto= 430,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS BARRIO HUAZIHUL",
              latitud= -31.519427,
              longitud= -68.574014,
              telefono= "*sin dato*",
              direccion= "Sargento Cabral 393 Oeste. Barrio Huazihul",
              depto= 430,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS DOCENTES SANJUANINOS",
              latitud= -31.551642,
              longitud= -68.565826,
              telefono= "*sin dato*",
              direccion= "Sargento Acosta S/Nº sur Sector 3 Mzna 3. Bº UDAP III.",
              depto= 430,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS DR RENE FAVALORO (B RIVADAVIA SUR)",
              latitud= -31.551376,
              longitud= -68.551508,
              telefono= "4343987",
              direccion= "Las Heras 1159 Oeste. Bº Rivadavia.",
              depto= 430,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS LA BEBIDA",
              latitud= -31.539705,
              longitud= -68.616779,
              telefono= "*sin dato*",
              direccion= "Ignacio de la Roza 4258 Oeste. La Bebida.",
              depto= 430,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS LOTE HOGAR Nº 3",
              latitud= -31.538827,
              longitud= -68.632585,
              telefono= "*sin dato*",
              direccion= "Entre Atencio Ignacio de la Rozay Morón. Lote Hogar 3. La Bebida.",
              depto= 430,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS MATERNO INFANTIL DOMINGA RAIMUNDO",
              latitud= -31.526442,
              longitud= -68.632387,
              telefono= "*sin dato*",
              direccion= "Av.Libertador San Martin y Galindez-Marquesado - RIVADAVIA.",
              depto= 430,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS RIVADAVIA NORTE",
              latitud= -31.5129,
              longitud= -68.580822,
              telefono= "*sin dato*",
              direccion= "Cano y Larralde S/Nº. Bº Rivadavia Norte.",
              depto= 430,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS RODRIGUEZ PINTO",
              latitud= -31.536094,
              longitud= -68.569451,
              telefono= "*sin dato*",
              direccion= "Centenario 627 Sur. Villa Rodriguez Pinto",
              depto= 430,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS ROLANDO CONTURSO (LOTE HOGAR N 53)",
              latitud= -31.51987382104273,
              longitud= -68.61923217773438,
              telefono= "*sin dato*",
              direccion= "Proyectada S/Nº. Unición Vecinal Lote Hogar Nº 53. Marquesado.",
              depto= 430,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS SAN JUSTO",
              latitud= -31.551915527480208,
              longitud= -68.62747192382812,
              telefono= "*sin dato*",
              direccion= "Proyectada S/Nº. Bº Bernardino Rivadavia. La Bebida.",
              depto= 430,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS BARRIO INDEPENDENCIA",
              latitud= -31.506128392881433,
              longitud= -68.3311253786087,
              telefono= "*sin dato*",
              direccion= "Barrio Independencia San Isidro",
              depto= 429,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS EJERCITO DE LOS ANDES",
              latitud= -31.55841,
              longitud= -68.300675,
              telefono= "*sin dato*",
              direccion= "Independencia S/Nº. Villa Dominguito",
              depto= 429,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS DR EMILIO GALDEANO",
              latitud= -31.5108,
              longitud= -68.4647,
              telefono= "*sin dato*",
              direccion= "Balcarce y Av Nueva Argentina S/Nº Colonia Gutierrez",
              depto= 431,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS DR. HORACIO ANTONIO GRILLO",
              latitud= -31.53787120158133,
              longitud= -68.41804504394531,
              telefono= "*sin dato*",
              direccion= "Av Libertador 6236 Este. Alto de Sierra",
              depto= 431,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS VILLA DON ARTURO",
              latitud= -31.5339,
              longitud= -68.4739,
              telefono= "*sin dato*",
              direccion= "Av. Libertador 4071 Este",
              depto= 431,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS VILLA MARIA",
              latitud= -31.5443,
              longitud= -68.4948,
              telefono= "*sin dato*",
              direccion= "Los Almendros 2314 Bº Cooperativa Villa María",
              depto= 431,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS VILLA MARINI",
              latitud= -31.5217,
              longitud= -68.501,
              telefono= "4214044",
              direccion= "San Lorenzo 1137 Este. Villa Marini",
              depto= 431,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS CAÑADA HONDA",
              latitud= -31.9857,
              longitud= -68.549,
              telefono= "*sin dato*",
              direccion= "Ruta 318 S/Nº. Cañada Honda",
              depto= 432,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS CERRO VALDIVIA",
              latitud= -31.9022,
              longitud= -68.469,
              telefono= "*sin dato*",
              direccion= "Salvador María del Carril S/Nº. Colonia Fiscal",
              depto= 432,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS CIENAGUITA",
              latitud= -32.0721,
              longitud= -68.6923,
              telefono= "*sin dato*",
              direccion= "Ing. Adolfo Casale S/Nº. Cienaguita",
              depto= 432,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS COCHAGUAL CENTRO",
              latitud= -31.9131,
              longitud= -68.3744,
              telefono= "*sin dato*",
              direccion= "Carmona. Escuela Juan Pablo II. Cochagual",
              depto= 432,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS COCHAGUAL NORTE",
              latitud= -31.878,
              longitud= -68.3842,
              telefono= "*sin dato*",
              direccion= "Ruta Provincial 253. Cochagual",
              depto= 432,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS DIVISADERO",
              latitud= -32.0095,
              longitud= -68.6926,
              telefono= "*sin dato*",
              direccion= "Ing. Adolfo Casale S/Nº (Unión Vecinal). Divisadero",
              depto= 432,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS GUANACACHE",
              latitud= -32.0641,
              longitud= -68.5905,
              telefono= "*sin dato*",
              direccion= "Buenos Aires S/Nº. Escuela Olegario Andrade. Guanacache",
              depto= 432,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS LA CILVICA",
              latitud= -31.9654,
              longitud= -68.3219,
              telefono= "*sin dato*",
              direccion= "Avellaneda (Escuela G. C. Vigil). Cochagual",
              depto= 432,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS LAS LAGUNAS",
              latitud= -32.0435,
              longitud= -68.3696,
              telefono= "*sin dato*",
              direccion= "Mzna A Casa 5. Bº Las Lagunas",
              depto= 432,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS PEDERNAL",
              latitud= -32.1849,
              longitud= -68.7515,
              telefono= "*sin dato*",
              direccion= "Calle Principal S/Nº. Unión Vecinal. Pedernal",
              depto= 432,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS PUNTA DEL MEDANO",
              latitud= -31.8947,
              longitud= -68.4194,
              telefono= "*sin dato*",
              direccion= "Ruta km 295 y Ruta 253. Punta del Médano",
              depto= 432,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS RETAMITO",
              latitud= -32.0933,
              longitud= -68.6191,
              telefono= "*sin dato*",
              direccion= "Ing. Adolfo Casale (Escuela). Retamito",
              depto= 432,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS SAN CARLOS",
              latitud= -32.145385562629315,
              longitud= -68.49151611328125,
              telefono= "*sin dato*",
              direccion= "Ruta Nacional 40. San Carlos",
              depto= 432,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS TRES ESQUINAS",
              latitud= -32.05027987804489,
              longitud= -68.41529846191406,
              telefono= "*sin dato*",
              direccion= "calle 25 de Mayo entre Carpino y Aranda. Barrio Tres Esquina",
              depto= 432,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS ALEJANDRO ROYON",
              latitud= -31.4768,
              longitud= -68.751,
              telefono= "*sin dato*",
              direccion= "Proyectada S/Nº. Villa Santa Rosa. Villa Aurora",
              depto= 425,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS ULLUM",
              latitud= -31.4584,
              longitud= -68.7179,
              telefono= "4943008",
              direccion= "Valentín Ruiz S/Nº. Villa Ibañez",
              depto= 425,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS AGUA CERCADA",
              latitud= -30.59891181819194,
              longitud= -67.48077392578125,
              telefono= "*sin dato*",
              direccion= "Ruta 510. Agua Cercada",
              depto= 426,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS ASTICA",
              latitud= -30.9539,
              longitud= -67.3039,
              telefono= "*sin dato*",
              direccion= "Fabián Atencio S/Nº",
              depto= 426,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS BALDE DE ASTICA",
              latitud= -30.9336,
              longitud= -67.2502,
              telefono= "*sin dato*",
              direccion= "Camino Comunal. Baldes de Astica",
              depto= 426,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS BALDE DE FUNES",
              latitud= -30.654452824400725,
              longitud= -67.5,
              telefono="*sin dato*",
              direccion= "Camino Comunal S/Nº. Balde de Funes",
              depto= 426,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS BALDE DE LAS CHILCAS",
              latitud= -30.6425,
              longitud= -67.4022,
              telefono= "*sin dato*",
              direccion= "Ruta 510 S/Nº. Balde de las Chilcas",
              depto= 426,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS BALDE DEL ROSARIO",
              latitud= -30.3248,
              longitud= -67.6958,
              telefono= "*sin dato*",
              direccion= "Ruta 510 S/Nº. Balde del Rosario",
              depto= 426,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS BALDE DEL SUR DE CHUCUMA",
              latitud= -31.10233357287178,
              longitud= -67.29537963867188,
              telefono= "*sin dato*",
              direccion= "Camino Comunal S/Nº. Balde de Chucuma",
              depto= 426,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS BALDECITOS",
              latitud= -30.2181,
              longitud= -67.6966,
              telefono= "*sin dato*",
              direccion= "Ruta 510. Baldecitos",
              depto= 426,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS CHUCUMA",
              latitud= -31.0711,
              longitud= -67.2766,
              telefono= "*sin dato*",
              direccion= "Ruta 510 S/Nº Chucuma",
              depto= 426,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS LA MAJADITA",
              latitud= -30.360730119782584,
              longitud= -67.65689849853516,
              telefono= "*sin dato*",
              direccion= "Camino Comunal S/Nº. La Majadita",
              depto= 426,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS LOS BRETES",
              latitud= -30.702877445958027,
              longitud= -67.41622924804688,
              telefono= "*sin dato*",
              direccion= "Camino Comunal S/Nº. Los Bretes",
              depto= 426,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS SEGUNDO T ELIZONDO (SIERRAS DE CHAVEZ)",
              latitud= -30.440386086566367,
              longitud= -67.54806518554688,
              telefono= "*sin dato*",
              direccion= "Camino Comunal S/Nº. Sierras de Chavez",
              depto= 426,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS SIERRAS DE ELIZONDO",
              latitud= -30.426177145763013,
              longitud= -67.58514404296875,
              telefono= "*sin dato*",
              direccion= "Camino Comunal S/Nº. Sierras de Elizondo",
              depto= 426,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS SIERRAS DE RIVEROS",
              latitud= -30.37405999207124,
              longitud= -67.6153564453125,
              telefono= "*sin dato*",
              direccion= "Sierras de Riveros",
              depto= 426,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS USNO",
              latitud= -30.5661,
              longitud= -67.54,
              telefono= "*sin dato*",
              direccion= "Ruta 510 S/Nº.",
              depto= 426,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS DOMINGO RAMON CEJAS",
              latitud= -32.0361,
              longitud= -68.2101,
              telefono= "4974045",
              direccion= "Mariano Moreno s/Nº. Las Casuarinas",
              depto= 427,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS EL ENCON",
              latitud= -32.00137975782923,
              longitud= -68.04485321044922,
              telefono= "4200201",
              direccion= "Ruta 20 S/Nº. Bº Juan Albarracín.",
              depto= 427,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS LA CHIMBERA",
              latitud= -31.8359,
              longitud= -68.3545,
              telefono= "*sin dato*",
              direccion= "Ruperto Martín S/Nº. La Chimbera",
              depto= 427,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS LAS TRANCAS",
              latitud= -31.596914,
              longitud= -68.273919,
              telefono= "*sin dato*",
              direccion= "Ruta 20 S/Nº. Las Trancas",
              depto= 427,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS PASCUAL CHENA",
              latitud= -31.73400724374667,
              longitud= -68.2661247253418,
              telefono= "*sin dato*",
              direccion= "Calle 2 y 22. Santa Rosa",
              depto= 427,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS PUNTA DEL AGUA",
              latitud= -31.85656420395222,
              longitud= -68.24226379394531,
              telefono= "*sin dato*",
              direccion= "Escuela Federico Magio. Punta del Agua",
              depto= 427,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS SANTA ROSA",
              latitud= -31.8274,
              longitud= -68.2461,
              telefono= "4978014",
              direccion= "25 de Mayo y Mitre S/Nº.",
              depto= 427,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS TUPELI",
              latitud= -31.8132,
              longitud= -68.3285,
              telefono= "*sin dato*",
              direccion= "Bº Seru. Tupelí",
              depto= 427,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS VILLA LA SALUD",
              latitud= -31.75064950256234,
              longitud= -68.236083984375,
              telefono= "*sin dato*",
              direccion= "calle 3 entre calles 24 y 25. Villa El Tango",
              depto= 427,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS ZONDA",
              latitud= -31.5533,
              longitud= -68.7294,
              telefono= "4945003",
              direccion= "Ruta 20 4165. Villa Basilio Nievas",
              depto= 428,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS ALTO CALINGASTA",
              latitud= 0.0,
              longitud= 0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 441,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS LA ISLA",
              latitud= 0.0,
              longitud= 0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 441,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS SOROCAYENSE",
              latitud= -31.333533087054338,
              longitud= -69.42097663879395,
              telefono= "*sin dato*",
              direccion= "Av Presidente Roca S/Nº. Sorocayense (Rutas 406 y 412)",
              depto= 441,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS TRES ESQUINAS",
              latitud= -30.18549602210943,
              longitud= -68.73458862304688,
              telefono= "*sin dato*",
              direccion= "Euguenio Flores S/n   - Tres esquinas",
              depto= 435,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS VILLA ALBA",
              latitud= -31.50792852318234,
              longitud= -68.50829601287842,
              telefono= "*sin dato*",
              direccion= "J.j. Urquiza 1486. Villa Urquiza",
              depto= 431,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CENTRO DE RADIOLOGIA ODONTOLOGICA DE ALTA COMPLEJIDAD C.R.O.A.C.",
              latitud= 0.0,
              longitud= 0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 439,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CENTRO MEDICO ODONTOLOGICO GENERAL PAZ",
              latitud= 0.0,
              longitud= 0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 439,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CENTRO MEDICO ODONTOLOGICO INDEPENDENCIA",
              latitud= 0.0,
              longitud= 0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 437,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CENTRO MEDICO ODONTOLOGICO Y SERVICIO DE ATENCION DOMICILIARIA",
              latitud= 0.0,
              longitud= 0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 432,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CENTRO ODONTOLOGICO MININ",
              latitud=0.0,
              longitud=0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 439,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS LAS TAPIAS",
              latitud= -31.408248857678068,
              longitud= -68.39176464424132,
              telefono= "*sin dato*",
              direccion= "21 DE FEBRERO E/ NACIONAL Y OLIVERA S/Nº",
              depto= 443,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CIC LA PUNTILLA (CAPS ARNOLDO JANSSEN)",
              latitud= -31.550452675471497,
              longitud= -68.30483436584473,
              telefono= "*sin dato*",
              direccion= "Calle 20 de Junio y Florida. La Puntilla",
              depto= 429,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CLINICA ODONTOLOGICA ACOSTA BENEGAS HERRERA",
              latitud=0.0,
              longitud=0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 439,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CLINICA ODONTOLOGICA CLINICA DE EXCELENCIA",
              latitud=0.0,
              longitud=0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 439,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CLINICA ODONTOLOGICA RAMIREZ",
              latitud=0.0,
              longitud=0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 439,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CONSULTORIO MEDICO Y ODONTOLOGICO MORETTI",
              latitud=0.0,
              longitud=0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 439,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CONSULTORIOS MEDICOS DE TRAUMATOLOGIA Y ODONTOLOGIA AGUILERA",
              latitud=0.0,
              longitud=0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 439,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CONSULTORIOS MEDICOS Y CONSULTORIO ODONTOLOGICO DE GAMI SRL",
              latitud=0.0,
              longitud=0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 439,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CONSULTORIOS MEDICOS Y SERVICIO DE ODONTOLOGIA DE CIAME SRL",
              latitud=0.0,
              longitud=0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 432,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CONSULTORIOS ODONTOLOGICOS DE FERNIGRINI",
              latitud=0.0,
              longitud=0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 439,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CONSULTORIOS ODONTOLOGICOS DE SCADDING",
              latitud=0.0,
              longitud=0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 430,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CONSULTORIOS ODONTOLOGICOS HUESO",
              latitud=0.0,
              longitud=0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 437,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CONSULTORIOS ODONTOLOGICOS Y CONSULTORIO MEDICO CENTRO INTEGRAL SANTA FE",
              latitud=0.0,
              longitud=0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 439,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CONSULTORIOS ODONTOLOGICOS Y CONSULTORIO PARA ATENCION PSICOLOGICA DE COBO",
              latitud=0.0,
              longitud=0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 439,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS VILLA OBSERVATORIO",
              latitud=0.0,
              longitud=0.0,
              telefono= "NULL",
              direccion= "Calle Malvinas Argentinas S/N",
              depto= 437,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS A. Cordero-CIC Dos Acequias",
              latitud=0.0,
              longitud=0.0,
              telefono= "NULL",
              direccion= "C/ Nacional y Rodríguez S/N",
              depto= 429,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "CAPS BARRIO RIO BLANCO",
              latitud=0.0,
              longitud=0.0,
              telefono= "NULL",
              direccion= "Segundo Sombra entre Calvento y Devoto",
              depto= 433,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },
            new {
                          nombre= "Unidad Movil Odontologica",
              latitud=0.0,
              longitud=0.0,
              telefono= "NULL",
              direccion= "NULL",
              depto= 439,
              ImgUrl= "http://cdn.memegenerator.es/imagenes/memes/full/4/25/4252823.jpg"
            },}.ToList();
//#endregion


            return Json(ubicaciones2);
        }

        // GET: api/Ubicaciones/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Ubicaciones
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Ubicaciones/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Ubicaciones/5
        public void Delete(int id)
        {
        }
    }
}
