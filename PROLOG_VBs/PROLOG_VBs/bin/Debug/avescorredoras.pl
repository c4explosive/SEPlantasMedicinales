%Base de Hechos

%Aves Principales

tipos_de(avestruz,aves_corredoras).
tipos_de(emu,aves_corredoras).
tipos_de(nandues,aves_corredoras).

%Posee (izq)
   posee(patas_largas,avestruz).
   posee(patas_fuertes,emu).
   posee(patas_largas,nandues).

%Tiene (der)
   tiene(dos_dedos_en_las_patas,avestruz).
   tiene(tres_dedos_en_las_patas,emu).
   tiene(tres_dedos_en_las_patas,nandues).

%Visual cargame...

cargar(N) :- exists_file(N), consult(N).

%3.a
son_aves_corredoras(X) :- tipos_de(X,aves_corredoras).

%3.b
avc_tresdedos(X) :- tiene(tres_dedos_en_las_patas,X), tipos_de(X,aves_corredoras).

%3.c (Obligatoria)
avc_dosd_pl(X) :- tiene(dos_dedos_en_las_patas,X), posee(patas_largas,X), tipos_de(X,aves_corredoras).

%3.d (Obligatoria)
caracteristica_nandues(X) :- (posee(X,nandues);tiene(X,nandues)),tipos_de(nandues,aves_corredoras).

%3.d (alt)

car_nandues(X,Y) :- posee(X,nandues),tiene(Y,nandues),tipos_de(nandues,aves_corredoras).
