%%Declaraciones

%Areas for consult only


%Areas o zonas de la enfermedad

area(sistema_inmunologico, inflamaciones).
area(sistema_inmunologico, fiebre).

area(piel, irritacion).
area(piel, varices).
area(piel, acne).
area(piel, golpes).
area(piel, herpes).

area(cabeza, dolor_de_cabeza).
area(cabeza, caida_de_cabello).
area(cabeza, caspa).

%area(estomago, dolores_estomacales).
%%area(estomago, parasitos).
%area(estomago, fatiga).

%area(boca, aftas_bucales).
%area(boca, inflamacion_de_amigdalas).
area(boca, dolor_de_muela).

area(higado, bilis).
area(higado, calculos_biliares).

area(huesos, dolores_reumaticos).
area(huesos, artritis).

area(oido, dolor_de_oido).

area(ojos, conjuntivitis).

area(riñones, retencion_de_liquidos).
area(riñones, infeccion_urinaria).

area(sistema_nervioso, nerviosismo).
area(sistema_nervioso, insomnio).

area(sistema_respiratorio, tos).
area(sistema_respiratorio, gripe).
area(sistema_respiratorio, resfriado).
area(sistema_respiratorio, hemorragias_nasales).
area(sistema_respiratorio, bronquitis).
area(sistema_respiratorio, ronquidos).
area(sistema_respiratorio, asma).

%area(sangre, anemia).

%Modo de Preparación

preparacion(decoccion, inflamaciones).
preparacion(cataplasma, inflamaciones).
preparacion(maceracion, inflamaciones).
preparacion(decoccion, fiebre).
preparacion(decoccion, fiebre).

preparacion(pulpa, irritacion).
preparacion(pulpa, varices).
preparacion(cataplasma, varices).
preparacion(cataplasma,dolor_de_muela).
preparacion(pulpa, acne).
preparacion(maceracion, acne).
preparacion(decoccion, acne).
preparacion(tintura, golpes).
preparacion(aceite_esencial, herpes).
preparacion(aceite_esencial, ronquidos).

preparacion(infusion, dolor_de_cabeza).
preparacion(tintura, dolor_de_cabeza).
preparacion(decoccion, dolor_de_cabeza).
preparacion(decoccion, caida_de_cabello).
preparacion(infusion, caida_de_cabello).
preparacion(infusion, caspa).

preparacion(jugo, bilis).
preparacion(decoccion, calculos_biliares).

preparacion(tintura, dolores_reumaticos).
preparacion(decoccion, dolores_reumaticos).
preparacion(aceite_esencial, dolores_reumaticos).
preparacion(cataplasma, artritis).
preparacion(infusion, artritis).

preparacion(jugo, dolor_de_oido).

preparacion(infusion, conjuntivitis).

preparacion(infusion, retencion_de_liquidos).
preparacion(decoccion, infeccion_urinaria).

preparacion(decoccion, nerviosismo).
preparacion(extracto, nerviosismo).
preparacion(infusion, nerviosismo).
preparacion(infusion, insomnio).

preparacion(infusion, tos).
preparacion(jarabe, gripe).
preparacion(infusion, resfriado).
preparacion(jugo, hemorragias_nasales).
preparacion(infusion, bronquitis).
preparacion(esencia, bronquitis).
preparacion(infusion, asma).



planta(eucalipto, aceite_esencial).
planta(oregano, aceite_esencial).
planta(yerbabuena, aceite_esencial).
planta(canela, aceite_esencial).

planta(laurel, cataplasma).
planta(llanten, cataplasma).
planta(manzanilla, cataplasma).
planta(cidron, cataplasma).

planta(achiote, decoccion).
planta(anis, decoccion).
planta(jengibre, decoccion).
planta(laurel, decoccion).
planta(manzanilla, decoccion).
planta(ortiga, decoccion).
planta(romero, decoccion).
planta(salvia, decoccion).
planta(yerbabuena, decoccion).
planta(boldo, decoccion).
planta(canela, decoccion).

planta(canela, esencia).

planta(toronjil, extracto).

planta(achiote, infusion).
planta(anis, infusion).
planta(laurel, infusion).
planta(llanten, infusion).
planta(manzanilla, infusion).
planta(oregano, infusion).
planta(ortiga, infusion).
planta(paico, infusion).
planta(perejil, infusion).
planta(ruda, infusion).
planta(tamarindo, infusion).
planta(tilo, infusion).
planta(valeriana, infusion).
planta(yerbabuena, infusion).
planta(cidron, infusion).
planta(boldo, infusion).

planta(canela, jarabe).

planta(llanten, jugo).
planta(ortiga, jugo).
planta(paico, jugo).
planta(tamarindo, jugo).
planta(boldo, jugo).

planta(laurel, maceracion).
planta(perejil, maceracion).

planta(aloe_vera, pulpa).
planta(tamarindo, pulpa).

planta(arnica, tintura).
planta(valeriana, tintura).

%Enfermedad, preparacion, planta
 
enfermedad(inflamaciones, achiote).
enfermedad(bronquitis, achiote).
enfermedad(dolores_estomacales, aloe_vera).
enfermedad(irritacion, aloe_vera).
enfermedad(varices, aloe_vera).
enfermedad(acne, aloe_vera).
enfermedad(dolor_de_cabeza, anis).
enfermedad(dolores_estomacales, anis).
enfermedad(golpes, arnica).
enfermedad(dolores_reumaticos, arnica).
enfermedad(aftas_bucales, eucalipto).
enfermedad(herpes, eucalipto).
enfermedad(dolores_estomacales, jengibre).
enfermedad(artritis, laurel).
enfermedad(acne, laurel).
enfermedad(caida_de_cabello, laurel).
enfermedad(retencion_de_liquidos, laurel).
enfermedad(dolor_de_oido, llanten).
enfermedad(tos, llanten).
enfermedad(varices, llanten).
enfermedad(inflamaciones, llanten).
enfermedad(inflamaciones, manzanilla).
enfermedad(dolores_reumaticos, manzanilla).
enfermedad(asma, manzanilla).
enfermedad(bronquitis, oregano).
enfermedad(tos, oregano).
enfermedad(asma, oregano).
enfermedad(dolores_reumaticos, oregano).
enfermedad(acne, ortiga).
enfermedad(caspa, ortiga).
enfermedad(caida_de_cabello, ortiga).
enfermedad(hemorragias_nasales, ortiga).
enfermedad(bronquitis, paico).
enfermedad(dolores_estomacales, paico).
enfermedad(parasitos, paico).
enfermedad(inflamaciones, perejil).
enfermedad(retencion_de_liquidos, perejil).
enfermedad(nerviosismo, romero).
enfermedad(fiebre, romero).
enfermedad(conjuntivitis, ruda).
enfermedad(ronquidos, ruda).
enfermedad(anemia, salvia).
enfermedad(fatiga, salvia).
enfermedad(bilis, tamarindo).
enfermedad(dolores_estomacales, tamarindo).
enfermedad(fiebre, tamarindo).
enfermedad(resfriado, tilo).
enfermedad(insomnio, tilo).
enfermedad(nerviosismo, toronjil).
enfermedad(dolor_de_cabeza, valeriana).
enfermedad(insomnio, valeriana).
enfermedad(dolores_estomacales, yerbabuena).
enfermedad(dolores_estomacales, yerbabuena).
enfermedad(infeccion_urinaria, yerbabuena).
enfermedad(nerviosismo, cidron).
enfermedad(dolor_de_muela, cidron).
enfermedad(dolores_estomacales, cidron).
enfermedad(calculos_biliares, boldo).
enfermedad(artritis, boldo).
enfermedad(dolor_de_cabeza, boldo).
enfermedad(dolor_de_oido, boldo).
enfermedad(bronquitis, canela).
enfermedad(dolores_reumaticos, canela).
enfermedad(gripe, canela).
enfermedad(dolores_estomacales, canela).


form(r1_achiote,achiote,decoccion).
form(r1_aloevera,aloevera,jugo).
form(r1_anis,anis,infusion).
form(r1_arnica,arnica,tintura).
form(r1_boldo,boldo,decoccion).
form(r1_canela,canela,esencia).
form(r1_cidron,cidron,infusion).
form(r1_eucalipto,eucalipto,aceite_esencial).
form(r1_jengibre,jengibre,decoccion).
form(r1_laurel,laurel,cataplasma).
form(r1_llanten,llanten,jugo).
form(r1_manzanilla,manzanilla,cataplasma).
form(r1_oregano,oregano,infusion).
form(r1_ortiga,ortiga,decoccion).
form(r1_paico,paico,infusion).
form(r1_perejil,perejil,maceracion).
form(r1_romero,romero,decoccion).
form(r1_ruda,ruda,infusion).
form(r1_salvia,salvia,decoccion).
form(r1_tamarindo,tamarindo,jugo).
form(r1_tilo,tilo,infusion).
form(r1_toronjil,toronjil,extracto).
form(r1_valeriana,valeriana,tintura).
form(r1_yerbabuena,yerbabuena,aceite_esencial).

form(r2_achiote,achiote,infusion).
form(r2_aloevera,aloevera,pulpa).
form(r2_anis,anis,decoccion).
form(r2_arnica,arnica,tintura).
form(r2_boldo,boldo,infusion).
form(r2_canela,canela,aceite_esencial).
form(r2_cidron,cidron,cataplasma).
form(r2_eucalipto,eucalipto,aceite_esencial).
form(r2_laurel,laurel,maceracion).
form(r2_llanten,llanten,infusion).
form(r2_manzanilla,manzanilla,decoccion).
form(r2_oregano,oregano,infusion).
form(r2_ortiga,ortiga,infusion).
form(r2_paico,paico,jugo).
form(r2_perejil,perejil,decoccion).
form(r2_romero,romero,decoccion).
form(r2_ruda,ruda,aceite_esencial).
form(r2_salvia,salvia,decoccion).
form(r2_tamarindo,tamarindo,pulpa).
form(r2_tilo,tilo,infusion).
form(r2_valeriana,valeriana,infusion).
form(r2_yerbabuena,yerbabuena,infusion).

form(r3_aloevera,aloevera,pulpa).
form(r3_boldo,boldo,decoccion).
form(r3_canela,canela,jarabe).
form(r3_cidron,cidron,infusion).
form(r3_laurel,laurel,decoccion).
form(r3_llanten,llanten,cataplasma).
form(r3_manzanilla,manzanilla,infusion).
form(r3_oregano,oregano,infusion).
form(r3_ortiga,ortiga,infusion).
form(r3_paico,paico,infusion).
form(r3_perejil,perejil,infusion).
form(r3_salvia,salvia,maceracion).
form(r3_tamarindo,tamarindo,infusion).
form(r3_yerbabuena,yerbabuena,decoccion).

form(r4_aloevera,aloevera,pulpa).
form(r4_boldo,boldo,jugo).
form(r4_canela,canela,decoccion).
form(r4_laurel,laurel,infusion).
form(r4_llanten,llanten,jugo).
form(r4_oregano,oregano,aceite_esencial).
form(r4_ortiga,ortiga,jugo).

%Visual cargame...

cargar(N) :- exists_file(N), consult(N).

%Son plantas de jugos
planta_jugo(X):- planta(X, jugo).
areas_get(X) :- area(X,Y).
areas_get_filt(X) :- distinct(areas_get(X)).
enfermedades_get(X,Z) :- area(X,Z).


preparacion_get(X,Z) :- distinct(preparacion(X,Z)).

plantas_get(X,Z) :- planta(X,Z).
plantas_get_s(X) :- planta(X,Z).
plantas_get_s_filt(X) :- distinct(plantas_get_s(X)).

get_form(X,Y,Z):- form(X,Y,Z).
plas_prep_enf_get(X,Y,Z):- planta(X,Y),enfermedad(Z,X),preparacion(Y,Z).

%%form(r1_achiote,Y,Z) :- planta(la_planta,tipo_preparacion).

