import React from "react";
import "./Dienstleistungen.css";

function DienstleistungenPage() {
  return (
    <div className="container">
      <h1>Unsere Dienstleistungen</h1>
      <p>
        Wir bieten eine Vielzahl von Dienstleistungen rund um den Pilzigel an,
        beispielsweise die Pilzschere
        <br /> <img src="./img/Pilzschere.jpeg" />{" "}
      </p>{" "}
      <br /> <br /> Den Igepilzhut <br /> <img src="./img/Pilzhut.jpeg" />
      <p>
      Pilzzahnbürste
      <br /> 
      </p>
      <img src="./img/Pilzbürste.jpeg" />   
    </div>
  );
}

export default DienstleistungenPage;
