import { Link } from "react-router-dom";

function Home() {
    return (
        <div>
            <Link to="Employee">
                <button>All Employee List</button>
            </Link>
            <Link to="search">
                <button>search employee</button>
            </Link>
        </div>
    );
}

export default Home;