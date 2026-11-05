function CrimeDetails() {

    /*test data curently - stars category may need changed*/ const crimes = [
         {
            starscategory: "Theft", 
            addressx: "123 Main St",
            reportdate: "2026-10-26",
            reportstatus: "Open"
         },
         {
            starscategory: "Assault",
            addressx: "456 Vine St",
            reportdate: "2026-10-25",
            reportstatus: "Closed"
         }
    ];


  return (
      <section className="crime-details">
          <h2>Crime Details</h2>

          {crimes.map((crime, index) => (
              <div className="crime-card" key={index}>
                  <h3>{crime.starscategory}</h3>
                  <p>
                      <strong>Address:</strong>
                      {crime.addressx}
                  </p>
                  <p>
                      <strong>Date/Time:</strong>
                      {crime.reportdate}
                  </p>
                  <p>
                      <strong>Status:</strong>
                      {crime.reportstatus}
                  </p>
              </div>
          ))}

      </section>
  );
}

export default CrimeDetails;