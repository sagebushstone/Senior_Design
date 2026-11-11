function Map() {
    return (
        <div className="map">
            <iframe
                title="UC Campus Map"
                width="100%"
                height="700"
                style={{ border: "none" }}
                src="https://www.openstreetmap.org/export/embed.html?bbox=-84.5200%2C39.1280%2C-84.5100%2C39.1360&layer=mapnik"
            />
        </div>
    );
}

export default Map;
