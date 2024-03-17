import logo from './bowlinglogo.png';

function Header() {
  return (
    <header className="row navbar navbar-dark bg-dark">
      <div className="col-4">
        <img
          src={logo}
          className="logo"
          alt="logo"
          style={{ width: '150px', height: 'auto' }}
        />
      </div>
      <div className="col subtitle">
        <h1 className="text-white">
          Here are the BEST bowlers in the world!!!!!
        </h1>
      </div>
    </header>
  );
}

export default Header;
