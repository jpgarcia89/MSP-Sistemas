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


            var ubicaciones = new[]{
                                    #region ubicaciones
                                    new  { lat = -31.4388610199289, lng = -68.5136067867279, nombre = "HOSPITAL JOSE GIORDANO", direccion = "Calle Sarmiento S/Nº..,", telefono = "4911002" },
                                    new  { lat= -31.451138, lng= -68.403104, nombre= "HOSPITAL DR. ALFREDO RIZO ESPARZA", direccion= "DF SARMIENTO S/Nº", telefono= "4972018"},
                                    new  { lat= -31.327832853583537, lng= -69.41848754882812, nombre= "HOSPITAL  DR. ALDO  CANTONI", direccion= "AV. ARGENTINA S/Nº", telefono= "02648 421012"},
                                    new  { lat= -31.644166, lng= -69.471392, nombre= "HOSPITAL BARREAL", direccion= "LAS HERAS S/Nº", telefono= "02648 441060"},
                                    new  { lat= -31.53944397856179, lng= -68.51338148117065, nombre= "HOSPITAL DR. GUILLERMO RAWSON", direccion= "AV. RAWSON -SUR- 568", telefono= "0264 4227404/2272"},
                                    new  { lat= -31.650537, lng= -68.273837, nombre= "HOSPITAL DR. CESAR AGUILAR", direccion= "J. J. BUSTOS Y FERMIN RODRIGUEZ S/Nº", telefono= "4961110-4961032"},
                                    new  { lat= -30.187767, lng= -69.118225, nombre= "HOSPITAL TOMAS PERON", direccion= "SANTO DOMINGO S/Nº", telefono= "02647-493045"},
                                    new  { lat= -30.157002087161633, lng= -68.48503589630127, nombre= "HOSPITAL DE HUACO", direccion= "Calle San Martin S/N°", telefono= "02647-499933"},
                                    new  { lat= -30.235527, lng= -68.748334, nombre= "HOSPITAL SAN ROQUE", direccion= "25 DE MAYO E/ GRAL PAZ Y ABERASTAIN 859", telefono= "02647 420055"},
                                    new  { lat= -31.654367736505126, lng= -68.56347441673279, nombre= "HOSPITAL DR. FEDERICO CANTONI", direccion= "Av. Joaquin  Uñac  entre calle 10 y 11.", telefono= "4921052"},
                                    new  { lat= -31.53006178863218, lng= -68.59603643417358, nombre= "HOSPITAL DR MARCIAL V. QUIROGA", direccion= "AVDA.SAN MARTIN Y RASTREADOR CALIVAR 5499", telefono= "0264-4330880"},
                                    new  { lat= -31.517437, lng= -68.350531, nombre= "HOSPITAL DRA. STELLA MOLINA", direccion= "SARMIENTO Y MEGLIOLI S/Nº", telefono= "4971267             "},
                                    new  { lat= -31.984855516552862, lng= -68.42694997787476, nombre= "HOSPITAL DR. VENTURA LLOVERAS", direccion= "calle 25 DE MAYO S/Nº Villa Media Agua", telefono= "4941004"},
                                    new  { lat= -31.9533, lng= -68.6536, nombre= "HOSPITAL LOS BERROS", direccion= "RUTA PROVINCIAL  319 S/Nº", telefono= "4975122"},
                                    new  { lat= -30.6294, lng= -67.4654, nombre= "HOSPITAL DR. ALEJANDRO ALBARRACIN", direccion= "GRAL ACHA Y 25 DE MAYO S/Nº", telefono= "02646-420188"},
                                    new  { lat= -31.552152, lng= -68.653463, nombre= "HOSPITAL MENTAL EL ZONDA", direccion= "Ignacio de la Roza 8000 Oeste", telefono= "4212442"},
                                    new  { lat= -31.376063152751442, lng= -68.49889755249023, nombre= "CAPS EL RINCON", direccion= "El Rincón S/Nº. Obispo Zapata", telefono= "*sin dato*"},
                                    new  { lat= -31.402272, lng= -68.4689931, nombre= "CAPS LA CAÑADA", direccion= "Sarmiento entre Gral. Acha y Aberastain. La Cañada", telefono= "*sin dato*"},
                                    new  { lat= -31.405809929952255, lng= -68.49254608154297, nombre= "CAPS LAS LOMITAS", direccion= "La Laja 3850. Las Lomitas.", telefono= "*sin dato*"},
                                    new  { lat= -31.407156, lng= -68.384462, nombre= "CIC ANGACO", direccion= "Las Tapias S/Nº", telefono= "*sin dato*"},
                                    new  { lat= -31.41460027631321, lng= -68.51898193359375, nombre= "CAPS LAS TIERRITAS", direccion= "Calle Principal S/Nº. Las Tierritas", telefono= "*sin dato*"},
                                    new  { lat= -31.425075, lng= -68.445578, nombre= "CAPS CAMPO DE BATALLA", direccion= "Proyectada S/Nº Campo de Batalla", telefono= "*sin dato*"},
                                    new  { lat= -31.443089, lng= -68.283014, nombre= "CAPS EL BOSQUE", direccion= "El Bosque S/Nº", telefono= "*sin dato*"},
                                    new  { lat= -31.13407689018422, lng= -69.466552734375, nombre= "CAPS PUCHUZUN", direccion= "Ruta Provincial 412 Km 20. Puchuzun", telefono= "*sin dato*"},
                                    new  { lat= -31.464982360950497, lng= -69.4281005859375, nombre= "CAPS TAMBERIAS", direccion= "Alfonsina Storni S/Nº. Tamberías", telefono= "2648 492003"},
                                    new  { lat= -31.07190293438487, lng= -69.49007034301758, nombre= "CAPS VILLA NUEVA", direccion= "Ruta 20 Km 412. Villa Nueva", telefono= "*sin dato*"},
                                    new  { lat= -31.52242091711456, lng= -68.54896366596222, nombre= "CAPS ALFONSO BARASSI", direccion= "Matías Zavalla y San Lorenzo Bº Del Carmen", telefono= "4231922"},
                                    new  { lat= -31.51063601394296, lng= -68.52683544158936, nombre= "CAPS COMANDANTE CABOT", direccion= "Mary O Graham 56 Este Bº C. Cabot Concepción", telefono= "4276758"},
                                    new  { lat= -31.549418522407276, lng= -68.54716122150421, nombre= "CAPS LAS MARGARITAS", direccion= "Agustín Gomez esquina Juez Ramón Díaz. Villa del Carril", telefono= "4200214"},
                                    new  { lat= -31.61591666666, lng= -67.65105555555, nombre= "CAPS BERMEJO", direccion= "Ruta Nacional Km 14. Bermejo", telefono= "*sin dato*"},
                                    new  { lat= -31.6240422270494, lng= -68.31481218338013, nombre= "CAPS DR. RAUL ALFONSO FUEGO", direccion= "San Lorenzo y Torres S/Nº", telefono= "*sin dato*"},
                                    new  { lat= -31.665289803868568, lng= -68.3063793182373, nombre= "CAPS GUADALUPE", direccion= "Colon y Enfermera Medina El Rincon", telefono= "*sin dato*"},
                                    new  { lat= -31.490748764752368, lng= -67.357177734375, nombre= "CAPS LA PLANTA", direccion= "Escuela La Planta. Marayes", telefono= "*sin dato*"},
                                    new  { lat= -31.4620555555, lng= -67.35386111111, nombre= "CAPS MARAYES", direccion= "Ruta Nacional Km 51. Marayes", telefono= "*sin dato*"},
                                    new  { lat= -31.661404215495793, lng= -68.22389602661133, nombre= "CAPS PIE DE PALO", direccion= "San Lorenzo S/Nº. Cuadro Estación Pie de Palo", telefono= "*sin dato*"},
                                    new  { lat= -31.684716, lng= -68.263787, nombre= "CAPS POZO DE ALGARROBOS", direccion= "Paso de los Andes y Caseros. Pozo de los Algarrobos", telefono= "*sin dato*"},
                                    new  { lat= -31.591778, lng= -68.305321, nombre= "CAPS SAN AGUSTIN ROSCELLI", direccion= "Juan Lavalle S/Nº. La Puntilla", telefono= "*sin dato*"},
                                    new  { lat= -31.745102415233838, lng= -67.98545837402344, nombre= "CAPS VALLECITO", direccion= "Calle Principal S/Nº. Paraje Difunta Correa. Vallecito", telefono= "*sin dato*"},
                                    new  { lat= -31.62962, lng= -68.240725, nombre= "CAPS VIRGEN DE LA PAZ", direccion= "Rastreador Calívar S/Nº. Bº San Martín. Los Médanos", telefono= "*sin dato*"},
                                    new  { lat= -31.510681, lng= -68.589408, nombre= "CAPS COSTANERA NORTE", direccion= "Vidable S/Nº Bº Costanera.", telefono= "*sin dato*"},
                                    new  { lat= -31.505702727202152, lng= -68.5889184437027, nombre= "CAPS DR. JORGE HUMBERTO MIRA", direccion= "Rastreador Calívar S/Nº entre Arriero y Marucho. Villa Obrera", telefono= "*sin dato*"},
                                    new  { lat= -31.496700608235948, lng= -68.4761663009415, nombre= "CAPS FCO. GONZALEZ FERNANDEZ", direccion= "Av. Benavidez S/Nº. El Mogote", telefono= "*sin dato*"},
                                    new  { lat= -31.508195, lng= -68.523545, nombre= "CAPS JORGE RUIZ AGUILAR", direccion= "Fernandez Barrientos S/Nº. Barrio Independencia", telefono= "*sin dato*"},
                                    new  { lat= -31.501625, lng= -68.559493, nombre= "CAPS JOSE RUIZ", direccion= "René Favaloro y Tacuarí. Lote Hogar Nº 38", telefono= "*sin dato*"},
                                    new  { lat= -31.476577, lng= -68.487308, nombre= "CAPS MADRE TERESA DE CALCUTA", direccion= "Fernandez Barrientos S/Nº. Villa Videla. El Mogote", telefono= "*sin dato*"},
                                    new  { lat= -31.465082, lng= -68.518008, nombre= "CAPS MARIANO MORENO", direccion= "Ruta 40 y Calle 13 de Junio. Villa Mariano Moreno", telefono= "*sin dato*"},
                                    new  { lat= -31.509153, lng= -68.534394, nombre= "CAPS MONSEÑOR BAEZ LASPIUR", direccion= "Sarmiento y Lopez Pelaez. Villa El Salvador", telefono= "4315415"},
                                    new  { lat= -31.492776, lng= -68.533369, nombre= "CAPS RAMON CARRILLO", direccion= "Av Alem y 25 de Mayo", telefono= "4315454"},
                                    new  { lat= -31.507361403696645, lng= -68.5523271560669, nombre= "CAPS VILLA SAN PATRICIO", direccion= "Patagonia Oeste1617 y Tierney B° Los Tamarindos.", telefono= "*sin dato*"},
                                    new  { lat= -30.05557412659814, lng= -69.17426705360413, nombre= "CAPS ANGUALASTO", direccion= "Calle Principal S/Nº. Angualasto..", telefono= "*sin dato*"},
                                    new  { lat= -30.440386086566366, lng= -69.24545288085937, nombre= "CAPS BELLA VISTA", direccion= "La Laguna S/Nº.", telefono= "*sin dato*          "},
                                    new  { lat= -30.18549602210943, lng= -69.10263061523437, nombre= "CAPS COLOLA", direccion= "Santo Domingo S/Nº. Colola", telefono= "*sin dato*          "},
                                    new  { lat= -30.398937557618676, lng= -69.2138671875, nombre= "CAPS IGLESIA", direccion= "Calle Principal S/Nº. Villa Iglesia", telefono= "*sin dato*          "},
                                    new  { lat= -30.323285680949706, lng= -69.20497298240662, nombre= "CAPS JUAN A. CARBAJAL", direccion= "Laprida S/Nº. Las Flores", telefono= "*sin dato*          "},
                                    new  { lat= -30.322552, lng= -69.271067, nombre= "CAPS TUDCUM", direccion= "San Roque S/Nº", telefono= "*sin dato*          "},
                                    new  { lat= -30.206861065952626, lng= -68.75518798828125, nombre= "CAPS ARBOL VERDE", direccion= "Tamberías. Jáchal", telefono= "*sin dato*          "},
                                    new  { lat= -30.20270711497636, lng= -68.76068115234375, nombre= "CAPS EL MEDANO", direccion= "Alfonso Hernandez S/Nº.", telefono= "*sin dato*          "},
                                    new  { lat= -30.22822147272595, lng= -68.64395141601562, nombre= "CAPS ENTRE RIOS", direccion= "Nueva Entre Rios S/Nº.", telefono= "*sin dato*          "},
                                    new  { lat= -30.200926796606026, lng= -68.75175476074219, nombre= "CAPS GRAN CHINA", direccion= "Gran China S/Nº", telefono= "*sin dato*          "},
                                    new  { lat= -30.67571540416773, lng= -68.367919921875, nombre= "CAPS MOGNA", direccion= "Argentina y Proyectada S/Nº. Mogna", telefono= "*sin dato*          "},
                                    new  { lat= -30.410099, lng= -68.689325, nombre= "CAPS NIQUIVIL", direccion= "Ruta Nacional Nº 40 y Centenario", telefono= "*sin dato*          "},
                                    new  { lat= -30.176889347682454, lng= -68.719482421875, nombre= "CAPS PAMPA DE CHAÑAR", direccion= "Noriega S/Nº. Pampa del Chañar", telefono= "*sin dato*          "},
                                    new  { lat= -30.17777972817965, lng= -68.80874633789062, nombre= "CAPS PAMPA VIEJA", direccion= "Varas S/Nº", telefono= "*sin dato*          "},
                                    new  { lat= -30.23771349789205, lng= -68.55880737304687, nombre= "CAPS SAN ISIDRO", direccion= "San Isidro", telefono= "*sin dato*          "},
                                    new  { lat= -30.285938, lng= -68.708757, nombre= "CAPS SAN ROQUE DE JACHAL", direccion= "Ruta Provincial 472 S/Nº.", telefono= "*sin dato*          "},
                                    new  { lat= -30.23118782903468, lng= -68.82041931152344, nombre= "CAPS TAMBERIAS", direccion= "Tamberías.", telefono= "*sin dato*          "},
                                    new  { lat= -30.146908510079008, lng= -68.65562438964844, nombre= "CAPS VILLA MERCEDES", direccion= "Eugenio Flores S/Nº", telefono= "*sin dato*          "},
                                    new  { lat= -31.6970060, lng= -68.389170, nombre= "CAPS ARTURO CABRAL DE LA COLINA", direccion= "Diagonal San Martín e Ignacio de la Roza S/Nº Vº 9 de Julio", telefono= "4977092             "},
                                    new  { lat= -31.593782, lng= -68.407798, nombre= "CAPS DR. CARLOS BOUTHERY", direccion= "Ruta 20 Km 14. Las Chacritas", telefono= "*sin dato*          "},
                                    new  { lat= -31.703086, lng= -68.590650, nombre= "CAPS ALDO HERMOSILLA", direccion= "Aberastain entre calles 14 y 15. La Rinconada", telefono= "*sin dato*          "},
                                    new  { lat= -31.61063008404481, lng= -68.60326766967773, nombre= "CAPS ALONSO FUEGO", direccion= "Costa Canal y Calle 8. Quinto Cuartel", telefono= "*sin dato*          "},
                                    new  { lat= -31.748166, lng= -68.556952, nombre= "CAPS BARRIO MUNICIPAL", direccion= "Mendoza entre calle 18 y callejón Frau 8273..", telefono= "*sin dato*          "},
                                    new  { lat= -31.819206, lng= -68.541783, nombre= "CAPS CHUBUT", direccion= "2 de Abril (Ruta 40 y Anacleto Gil Km 32). Barrio Chubut", telefono= "*sin dato*          "},
                                    new  { lat= -31.8594, lng= -68.5366, nombre= "CAPS DR M BRACCO", direccion= "Ruta 40 y calle Cantoni Mzna 6. Bº El Cerrillo", telefono= "*sin dato*          "},
                                    new  { lat= -31.682059, lng= -68.517856, nombre= "CAPS JOAQUIN UÑAC", direccion= "Alfonso XIII y calle 12", telefono= "*sin dato*          "},
                                    new  { lat= -31.591550082840896, lng= -68.56636047363281, nombre= "CAPS LOTE HOGAR Nº 27", direccion= "Vidart entre calles 5 y 6. Bº Lote Hogar Nº 27. Quinto Cuartel", telefono= "*sin dato*          "},
                                    new  { lat= -31.572132, lng= -68.529974, nombre= "CAPS VILLA CONSTITUCION", direccion= "Lemos S/Nº entre calles 5 y 6. Villa Constitución", telefono= "*sin dato*          "},
                                    new  { lat= -31.593965, lng= -68.528455, nombre= "CAPS VILLA HUARPES", direccion= "Aberastain y J.J. Bustos. Villa Huarpes", telefono= "*sin dato*          "},
                                    new  { lat= -31.593263, lng= -68.542600, nombre= "CAPS VILLA PAOLINI", direccion= "Alvear e Independencia. Villa Paolini", telefono= "*sin dato*          "},
                                    new  { lat= -31.623311369870308, lng= -68.49303960800171, nombre= "CAPS BARRIO BUBICA", direccion= "E. Palma y Miguel Bernal S/Nº. Bº Bubica. Medanito", telefono= "*sin dato*          "},
                                    new  { lat= -31.567200958823936, lng= -68.53962421417236, nombre= "CAPS CAPITAN LAZO", direccion= "San Martín y Misiones 280. Barrio Capitán Lazo", telefono= "*sin dato*          "},
                                    new  { lat= -31.573452, lng= -68.529032, nombre= "CAPS CENTRO DE ADIESTRAMIENTO DR RENE FAVALORO", direccion= "T del Fuego y Fermín Rodriguez Bº Residencial Rawson", telefono= "0264 - 4240924      "},
                                    new  { lat= -31.608392, lng= -68.513189, nombre= "CAPS COLONIA RODAS", direccion= "España y Tascheret S/Nº. Colonia Rodas", telefono= "*sin dato*          "},
                                    new  { lat= -31.620677, lng= -68.46262, nombre= "CAPS CRISTO REY", direccion= "Calle 5 entre Punta del Monte y América. Médano de Oro", telefono= "*sin dato*          "},
                                    new  { lat= -31.561642909963183, lng= -68.54988098144531, nombre= "CAPS DR. ELIO CANTONI", direccion= "Recuerdos de Provincia 1618 Oeste. Villa Hipódromo", telefono= "4340312             "},
                                    new  { lat= -31.558936897874887, lng= -68.56091022491455, nombre= "CAPS MARTIN GUEMES", direccion= "Velez Sarsfield y Capdevilla 402. Barrio Güemes", telefono= "*sin dato*          "},
                                    new  { lat= -31.582168, lng= -68.558926, nombre= "CAPS MAURIN NAVARRO", direccion= "Alvarez Condarco y Félix Aguilar. Bº Buenaventura Luna.", telefono= "4343448             "},
                                    new  { lat= -31.643362, lng= -68.500091, nombre= "CAPS MEDANO DE ORO", direccion= "Belgrano y calle 8. Médano de Oro", telefono= "*sin dato*          "},
                                    new  { lat= -31.574461, lng= -68.550849, nombre= "CAPS MONSEÑOR DI STEFANO", direccion= "Frías y Franklin 1240 Oeste. Bº La Estación", telefono= "4343940             "},
                                    new  { lat= -31.583251, lng= -68.532452, nombre= "CAPS 12 DE OCTUBRE", direccion= "Progreso y Chacabuco. Bº San Ricardo. Villa Krawse", telefono= "*sin dato*          "},
                                    new  { lat= -31.51785255714755, lng= -68.56418251991272, nombre= "CAPS Bº ARAMBURU", direccion= "Plumerillo y Bazan Agras. Paula Albarracin Oeste. Bº Aramburu", telefono= "*sin dato*          "},
                                    new  { lat= -31.519427, lng= -68.574014, nombre= "CAPS BARRIO HUAZIHUL", direccion= "Sargento Cabral 393 Oeste. Barrio Huazihul", telefono= "*sin dato*          "},
                                    new  { lat= -31.551642, lng= -68.565826, nombre= "CAPS DOCENTES SANJUANINOS", direccion= "Sargento Acosta S/Nº sur Sector 3 Mzna 3. Bº UDAP III.", telefono= "*sin dato*          "},
                                    new  { lat= -31.551376, lng= -68.551508, nombre= "CAPS DR RENE FAVALORO (B RIVADAVIA SUR)", direccion= "Las Heras 1159 Oeste. Bº Rivadavia.", telefono= "4343987             "},
                                    new  { lat= -31.539705, lng= -68.616779, nombre= "CAPS LA BEBIDA", direccion= "Ignacio de la Roza 4258 Oeste. La Bebida.", telefono= "*sin dato*          "},
                                    new  { lat= -31.538827, lng= -68.632585, nombre= "CAPS LOTE HOGAR Nº 3", direccion= "Entre Atencio Ignacio de la Rozay Morón. Lote Hogar 3. La Bebida.", telefono= "*sin dato*          "},
                                    new  { lat= -31.526442, lng= -68.632387, nombre= "CAPS MATERNO INFANTIL DOMINGA RAIMUNDO", direccion= "Av.Libertador San Martin y Galindez-Marquesado - RIVADAVIA.", telefono= "*sin dato*          "},
                                    new  { lat= -31.512900, lng= -68.580822, nombre= "CAPS RIVADAVIA NORTE", direccion= "Cano y Larralde S/Nº. Bº Rivadavia Norte.", telefono= "*sin dato*          "},
                                    new  { lat= -31.536094, lng= -68.569451, nombre= "CAPS RODRIGUEZ PINTO", direccion= "Centenario 627 Sur. Villa Rodriguez Pinto", telefono= "*sin dato*          "},
                                    new  { lat= -31.51987382104273, lng= -68.61923217773437, nombre= "CAPS ROLANDO CONTURSO (LOTE HOGAR N 53)", direccion= "Proyectada S/Nº. Unición Vecinal Lote Hogar Nº 53. Marquesado.", telefono= "*sin dato*          "},
                                    new  { lat= -31.551915527480208, lng= -68.62747192382812, nombre= "CAPS SAN JUSTO", direccion= "Proyectada S/Nº. Bº Bernardino Rivadavia. La Bebida.", telefono= "*sin dato*          "},
                                    new  { lat= -31.506128392881433, lng= -68.3311253786087, nombre= "CAPS BARRIO INDEPENDENCIA", direccion= "Barrio Independencia San Isidro", telefono= "*sin dato*          "},
                                    new  { lat= -31.558410, lng= -68.300675, nombre= "CAPS EJERCITO DE LOS ANDES", direccion= "Independencia S/Nº. Villa Dominguito", telefono= "*sin dato*          "},
                                    new  { lat= -31.5108, lng= -68.4647, nombre= "CAPS DR EMILIO GALDEANO", direccion= "Balcarce y Av Nueva Argentina S/Nº Colonia Gutierrez", telefono= "*sin dato*          "},
                                    new  { lat= -31.53787120158133, lng= -68.41804504394531, nombre= "CAPS DR. HORACIO ANTONIO GRILLO", direccion= "Av Libertador 6236 Este. Alto de Sierra", telefono= "*sin dato*          "},
                                    new  { lat= -31.5339, lng= -68.4739, nombre= "CAPS VILLA DON ARTURO", direccion= "Av. Libertador 4071 Este", telefono= "*sin dato*          "},
                                    new  { lat= -31.5443, lng= -68.4948, nombre= "CAPS VILLA MARIA", direccion= "Los Almendros 2314 Bº Cooperativa Villa María", telefono= "*sin dato*          "},
                                    new  { lat= -31.5217, lng= -68.501, nombre= "CAPS VILLA MARINI", direccion= "San Lorenzo 1137 Este. Villa Marini", telefono= "4214044             "},
                                    new  { lat= -31.9857, lng= -68.549, nombre= "CAPS CAÑADA HONDA", direccion= "Ruta 318 S/Nº. Cañada Honda", telefono= "*sin dato*          "},
                                    new  { lat= -31.9022, lng= -68.469, nombre= "CAPS CERRO VALDIVIA", direccion= "Salvador María del Carril S/Nº. Colonia Fiscal", telefono= "*sin dato*          "},
                                    new  { lat= -32.0721, lng= -68.6923, nombre= "CAPS CIENAGUITA", direccion= "Ing. Adolfo Casale S/Nº. Cienaguita", telefono= "*sin dato*          "},
                                    new  { lat= -31.9131, lng= -68.3744, nombre= "CAPS COCHAGUAL CENTRO", direccion= "Carmona. Escuela Juan Pablo II. Cochagual", telefono= "*sin dato*          "},
                                    new  { lat= -31.878, lng= -68.3842, nombre= "CAPS COCHAGUAL NORTE", direccion= "Ruta Provincial 253. Cochagual", telefono= "*sin dato*          "},
                                    new  { lat= -32.0095, lng= -68.6926, nombre= "CAPS DIVISADERO", direccion= "Ing. Adolfo Casale S/Nº (Unión Vecinal). Divisadero", telefono= "*sin dato*          "},
                                    new  { lat= -32.0641, lng= -68.5905, nombre= "CAPS GUANACACHE", direccion= "Buenos Aires S/Nº. Escuela Olegario Andrade. Guanacache", telefono= "*sin dato*          "},
                                    new  { lat= -31.9654, lng= -68.3219, nombre= "CAPS LA CILVICA", direccion= "Avellaneda (Escuela G. C. Vigil). Cochagual", telefono= "*sin dato*          "},
                                    new  { lat= -32.0435, lng= -68.3696, nombre= "CAPS LAS LAGUNAS", direccion= "Mzna A Casa 5. Bº Las Lagunas", telefono= "*sin dato*          "},
                                    new  { lat= -32.1849, lng= -68.7515, nombre= "CAPS PEDERNAL", direccion= "Calle Principal S/Nº. Unión Vecinal. Pedernal", telefono= "*sin dato*          "},
                                    new  { lat= -31.8947, lng= -68.4194, nombre= "CAPS PUNTA DEL MEDANO", direccion= "Ruta km 295 y Ruta 253. Punta del Médano", telefono= "*sin dato*          "},
                                    new  { lat= -32.0933, lng= -68.6191, nombre= "CAPS RETAMITO", direccion= "Ing. Adolfo Casale (Escuela). Retamito", telefono= "*sin dato*          "},
                                    new  { lat= -32.145385562629315, lng= -68.49151611328125, nombre= "CAPS SAN CARLOS", direccion= "Ruta Nacional 40. San Carlos", telefono= "*sin dato*          "},
                                    new  { lat= -32.05027987804489, lng= -68.41529846191406, nombre= "CAPS TRES ESQUINAS", direccion= "calle 25 de Mayo entre Carpino y Aranda. Barrio Tres Esquina", telefono= "*sin dato*          "},
                                    new  { lat= -31.4768, lng= -68.751, nombre= "CAPS ALEJANDRO ROYON", direccion= "Proyectada S/Nº. Villa Santa Rosa. Villa Aurora", telefono= "*sin dato*          "},
                                    new  { lat= -31.4584, lng= -68.7179, nombre= "CAPS ULLUM", direccion= "Valentín Ruiz S/Nº. Villa Ibañez", telefono= "4943008             "},
                                    new  { lat= -30.59891181819194, lng= -67.48077392578125, nombre= "CAPS AGUA CERCADA", direccion= "Ruta 510. Agua Cercada", telefono= "*sin dato*          "},
                                    new  { lat= -30.9539, lng= -67.3039, nombre= "CAPS ASTICA", direccion= "Fabián Atencio S/Nº", telefono= "*sin dato*          "},
                                    new  { lat= -30.9336, lng= -67.2502, nombre= "CAPS BALDE DE ASTICA", direccion= "Camino Comunal. Baldes de Astica", telefono= "*sin dato*          "},
                                    new  { lat= -30.654452824400724, lng= -67.5, nombre= "CAPS BALDE DE FUNES", direccion= "Camino Comunal S/Nº. Balde de Funes", telefono= "00000               "},
                                    new  { lat= -30.6425, lng= -67.4022, nombre= "CAPS BALDE DE LAS CHILCAS", direccion= "Ruta 510 S/Nº. Balde de las Chilcas", telefono= "*sin dato*          "},
                                    new  { lat= -30.3248, lng= -67.6958, nombre= "CAPS BALDE DEL ROSARIO", direccion= "Ruta 510 S/Nº. Balde del Rosario", telefono= "*sin dato*          "},
                                    new  { lat= -31.10233357287178, lng= -67.29537963867187, nombre= "CAPS BALDE DEL SUR DE CHUCUMA", direccion= "Camino Comunal S/Nº. Balde de Chucuma", telefono= "*sin dato*          "},
                                    new  { lat= -30.2181, lng= -67.6966, nombre= "CAPS BALDECITOS", direccion= "Ruta 510. Baldecitos", telefono= "*sin dato*          "},
                                    new  { lat= -31.0711, lng= -67.2766, nombre= "CAPS CHUCUMA", direccion= "Ruta 510 S/Nº Chucuma", telefono= "*sin dato*          "},
                                    new  { lat= -30.360730119782584, lng= -67.65689849853515, nombre= "CAPS LA MAJADITA", direccion= "Camino Comunal S/Nº. La Majadita", telefono= "*sin dato*          "},
                                    new  { lat= -30.702877445958027, lng= -67.41622924804687, nombre= "CAPS LOS BRETES", direccion= "Camino Comunal S/Nº. Los Bretes", telefono= "*sin dato*          "},
                                    new  { lat= -30.440386086566366, lng= -67.54806518554687, nombre= "CAPS SEGUNDO T ELIZONDO (SIERRAS DE CHAVEZ)", direccion= "Camino Comunal S/Nº. Sierras de Chavez", telefono= "*sin dato*          "},
                                    new  { lat= -30.426177145763013, lng= -67.58514404296875, nombre= "CAPS SIERRAS DE ELIZONDO", direccion= "Camino Comunal S/Nº. Sierras de Elizondo", telefono= "*sin dato*          "},
                                    new  { lat= -30.37405999207124, lng= -67.6153564453125, nombre= "CAPS SIERRAS DE RIVEROS", direccion= "Sierras de Riveros", telefono= "*sin dato*          "},
                                    new  { lat= -30.5661, lng= -67.54, nombre= "CAPS USNO", direccion= "Ruta 510 S/Nº.", telefono= "*sin dato*          "},
                                    new  { lat= -32.0361, lng= -68.2101, nombre= "CAPS DOMINGO RAMON CEJAS", direccion= "Mariano Moreno s/Nº. Las Casuarinas", telefono= "4974045             "},
                                    new  { lat= -32.00137975782923, lng= -68.04485321044922, nombre= "CAPS EL ENCON", direccion= "Ruta 20 S/Nº. Bº Juan Albarracín.", telefono= "4200201             "},
                                    new  { lat= -31.8359, lng= -68.3545, nombre= "CAPS LA CHIMBERA", direccion= "Ruperto Martín S/Nº. La Chimbera", telefono= "*sin dato*          "},
                                    new  { lat= -31.596914, lng= -68.273919, nombre= "CAPS LAS TRANCAS", direccion= "Ruta 20 S/Nº. Las Trancas", telefono= "*sin dato*          "},
                                    new  { lat= -31.73400724374667, lng= -68.2661247253418, nombre= "CAPS PASCUAL CHENA", direccion= "Calle 2 y 22. Santa Rosa", telefono= "*sin dato*          "},
                                    new  { lat= -31.85656420395222, lng= -68.24226379394531, nombre= "CAPS PUNTA DEL AGUA", direccion= "Escuela Federico Magio. Punta del Agua", telefono= "*sin dato*          "},
                                    new  { lat= -31.8274, lng= -68.2461, nombre= "CAPS SANTA ROSA", direccion= "25 de Mayo y Mitre S/Nº.", telefono= "4978014             "},
                                    new  { lat= -31.8132, lng= -68.3285, nombre= "CAPS TUPELI", direccion= "Bº Seru. Tupelí", telefono= "*sin dato*          "},
                                    new  { lat= -31.75064950256234, lng= -68.236083984375, nombre= "CAPS VILLA LA SALUD", direccion= "calle 3 entre calles 24 y 25. Villa El Tango", telefono= "*sin dato*          "},
                                    new  { lat= -31.5533, lng= -68.7294, nombre= "CAPS ZONDA", direccion= "Ruta 20 4165. Villa Basilio Nievas", telefono= "4945003             "},
                                    new  { lat= -31.333533087054338, lng= -69.42097663879395, nombre= "CAPS SOROCAYENSE", direccion= "Av Presidente Roca S/Nº. Sorocayense (Rutas 406 y 412)", telefono= "*sin dato*          "},
                                    new  { lat= -30.18549602210943, lng= -68.73458862304687, nombre= "CAPS TRES ESQUINAS", direccion= "Euguenio Flores S/n   - Tres esquinas", telefono= "*sin dato*          "},
                                    new  { lat= -31.50792852318234, lng= -68.50829601287842, nombre= "CAPS VILLA ALBA", direccion= "J.j. Urquiza 1486. Villa Urquiza", telefono= "*sin dato*          "},
                                    new  { lat= -31.5007, lng= -68.5121, nombre= "CIC - BARRIO LOS ANDES", direccion= "Patagonia y Greco. Barrio Los Andes", telefono= "4315856             "},
                                    new  { lat= -31.752, lng= -68.3121, nombre= "CIC 25 DE MAYO", direccion= "Ruta 270 entre 4 y 5. Bº Algarrobo Verde", telefono= "*sin dato*          "},
                                    new  { lat= -31.428, lng= -68.4956, nombre= "CIC ALBARDON", direccion= "La Laja esquina Nacional S/Nº.", telefono= "4912046             "},
                                    new  { lat= -31.408248857678068, lng= -68.39176464424132, nombre= "CAPS LAS TAPIAS", direccion= "21 DE FEBRERO E/ NACIONAL Y OLIVERA S/Nº", telefono= "*sin dato*          "},
                                    new  { lat= -31.424396879298164, lng= -68.54054689407348, nombre= "CIC FRANCISCO GIULANO (EX CAMPO AFUERA)", direccion= "Juan Lahoz y Proyectada.", telefono= "*sin dato*          "},
                                    new  { lat= -31.550452675471497, lng= -68.30483436584473, nombre= "CIC LA PUNTILLA (CAPS ARNOLDO JANSSEN)", direccion= "Calle 20 de Junio y Florida. La Puntilla", telefono= "*sin dato*          "},
                                    new  { lat= -31.629560013457468, lng= -68.47949981689453, nombre= "CIC MEDANO DE ORO", direccion= "Ramón Franco pasando calle 6.", telefono= "*sin dato*          "},
                                    new  { lat= -31.5923, lng= -68.5489, nombre= "CIC POCITO", direccion= "Lemos y Prolongación Picasso. Bº Salvador Norte", telefono= "4283275             "},
                                    new  { lat= -31.487381967265797, lng= -68.41667175292969, nombre= "CIC SAN MARTIN", direccion= "Nacional entre Rodriguez y Quiroga", telefono= "*sin dato*          "},
                                    new  { lat= -31.981279118769915, lng= -68.42704653739929, nombre= "CIC SARMIENTO", direccion= "calle 9 de Julio. Parrio Pagonia I.", telefono= "*sin dato*          "},
                                    new  { lat= -31.465421620445546, lng= -68.73518943786621, nombre= "CIC ULLUM", direccion= "Ullampa y Luján. Bº Ullum II", telefono= "4943382             "},
                                    new  { lat= -31.562512741611812, lng= -68.56220641247779, nombre= "CIC VILLA ANGELICA", direccion= "Bahía Blanca y Paso de los Andes. Villa Ángélica.", telefono= "4340611             "},
                                    new  { lat= -31.545415, lng= -68.732691, nombre= "CIC ZONDA", direccion= "Manuel  Andujar  s / nº", telefono= "*sin dato*          "},
                                    #endregion
                                }.ToList();

            return Json(ubicaciones);
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
